﻿------------------------DIRTY READ--------------------------
-------TH1-----------------
-------NHÂN VIÊN CẬP NHẬT GIÁ NHÀ BÁN-----
CREATE PROC UPDATE_PRICE @MANHA INT, @GIABAN FLOAT
AS
BEGIN TRAN
	UPDATE [dbo].[NhaBan] set GiaBan = @GIABAN where MaNha = @MANHA
	WAITFOR DELAY '00:00:05'
	IF((SELECT GiaBan FROM NhaBan WHERE MaNha = @MANHA) < 0)
		BEGIN
			ROLLBACK TRAN
			RETURN
		END
COMMIT TRAN

EXEC UPDATE_PRICE 2, -90
SELECT MaNha, GiaBan FROM NhaBan

------TH2---------------
---------NHÂN VIÊN THÊM 1 HỢP ĐỒNG
CREATE PROC ADD_CONTRACT  @MANHA INT, @MAKH INT, @DATEBEGIN DATE, @DATEEND DATE
AS 
BEGIN TRAN
	DECLARE @MAHD INT = (SELECT MAX(MaHopDong) FROM dbo.HopDongThue) + 1
	INSERT INTO HopDongThue(MaHopDong, MaNha, MaKH, NgayBatDau, NgayKetThuc)
	VALUES (@MAHD, @MANHA, @MAKH, @DATEBEGIN, @DATEEND)
	WAITFOR DELAY '00:00:05'

	IF(@DATEBEGIN > @DATEEND)
		BEGIN
			PRINT(N'LỖI')
			ROLLBACK TRAN
			RETURN
		END
COMMIT TRAN

EXEC ADD_CONTRACT 10, 1, '2020-09-09', '2020-08-09'

--------------TH3---------
----------------NHÂN VIÊN CẬP NHẬT GIÁ NHÀ BÁN-----
EXEC UPDATE_PRICE 2, -90
SELECT MaNha, GiaBan FROM NhaBan






----------------------------UNREPEATABLE READ-------------------
-------------TH1
-----------KHÁCH HÀNG TÌM NHÀ TRÊN ĐƯỜNG THEO TÌNH TRẠNG
CREATE PROC FIND_HOUSE_BY_STREET @TENDUONG_NHA CHAR(50), @TINHTRANG CHAR(50)
AS
BEGIN TRAN
	SELECT MaNha, TenDuong_Nha, TinhTrang 
	FROM Nha WHERE TenDuong_Nha = @TENDUONG_NHA
	WAITFOR DELAY '00:00:05'
	SELECT* FROM Nha WHERE TenDuong_Nha = @TENDUONG_NHA 
					AND TinhTrang = @TINHTRANG
COMMIT TRAN
	
EXEC FIND_HOUSE_BY_STREET 'Bach Dang', 'trong'

-------------TH2
-----------NHÂN VIÊN CẬP GIÁ NHÀ BÁN 
---------(1 trong những nhà có giá nhỏ hơn giá người dùng nhập) 
---------(thành giá lớn hơn giá người dùng nhập)
EXEC UPDATE_PRICE 2, 2000000000
SELECT MaNha, GiaBan FROM NhaBan






--------------------LOST UPDATE--------------
---------------TH1
-----------NHÂN VIÊN CẬP NHẬT TÌNH TRẠNG NHÀ
ALTER PROC UPDATE_STATUS_02 @MANHA INT, @STATUS CHAR(10)
AS
BEGIN TRAN
	DECLARE @STATUS_HOUSE CHAR(10) = (SELECT TinhTrang FROM Nha 
							WHERE MaNha = @MANHA)
	WAITFOR DELAY '00:00:05'
	SET @STATUS_HOUSE = @STATUS
	UPDATE Nha SET TinhTrang = @STATUS_HOUSE WHERE MaNha = @MANHA
	SELECT MaNha, TinhTrang FROM Nha
COMMIT TRAN

EXEC UPDATE_STATUS_02 1, 'kin'
SELECT TinhTrang FROM Nha

------------------PHANTOM-----------------
---------TH1-------
--------NHÂN VIÊN LẬP HỢP ĐỒNG CHO KHÁCH HÀNG
EXEC ADD_CONTRACT 10, 3, '2020-07-12', '2021-02-12'










---------TH2
------KHÁCH HÀNG XEM THÔNG TIN NHÂN VIÊN THEO MÃ CHI NHÁNH
CREATE PROC GetEmployeeByIDBranch @MACN INT
AS
	BEGIN TRAN
	SELECT MaNV, MaCN FROM NhanVien WHERE MaCN = @MACN
	WAITFOR DELAY '00:00:05'
	SELECT*  FROM dbo.NhanVien WHERE @MACN = MaCN
COMMIT TRAN

EXEC GetEmployeeByIDBranch 1





----------------------------CONVERSION DEADLOCK----------
-------------TH1
-----------NHÂN VIÊN CẬP NHẬT TÌNH TRẠNG NHÀ
CREATE PROC UPDATE_STATUS_02_CONVERSION_DL @MANHA INT, @STATUS CHAR(10)
AS
BEGIN TRAN
	SET TRAN ISOLATION LEVEL SERIALIZABLE
	DECLARE @STATUS_HOUSE CHAR(10) = (SELECT TinhTrang FROM Nha 
							WHERE MaNha = @MANHA)
	WAITFOR DELAY '00:00:05'
	SET @STATUS_HOUSE = @STATUS
	UPDATE Nha SET TinhTrang = @STATUS_HOUSE 
	WHERE MaNha = @MANHA
COMMIT TRAN

EXEC UPDATE_STATUS_02_CONVERSION_DL 1, 'kin'
SELECT TinhTrang FROM Nha

---------------------------CYCLE DEADLOCK-----------------------
--------------TH1
CREATE PROC CYCLE_DL_02 @MAKH INT, @MAPHIEU INT, @DIACHI CHAR(100), @TIEUCHI CHAR(100)
AS 
BEGIN TRAN
	UPDATE YeuCauKhachHang SET TieuChi = @TIEUCHI 
	WHERE MaKH = @MAKH AND MaPhieu = @MAPHIEU
	WAITFOR DELAY '00:00:10'
	UPDATE KhachHang SET DiaChiKH = @DIACHI
	WHERE MaKH = @MAKH
COMMIT TRAN

EXEC CYCLE_DL_02 9, 2, 'Binh Duong', 'co ban cong'