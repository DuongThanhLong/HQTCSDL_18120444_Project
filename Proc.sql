------------------------DIRTY READ--------------------------
-------TH1-----------------
-------KHÁCH HÀNG XEM GIÁ NHÀ BÁN-----
CREATE PROC CHECK_PRICE @MANHA INT
AS
BEGIN TRAN
	SELECT GiaBan FROM NhaBan WITH(NOLOCK)
	WHERE MaNha = @MANHA
COMMIT TRAN

EXEC CHECK_PRICE 2

------TH2---------------
--------KHÁCH HÀNG XEM THÔNG TIN CỦA 1 HỢP ĐỒNG
CREATE PROC SEE_CONTRACT @MAHOPDONG INT, @MANHA INT, @MAKH INT
AS
BEGIN TRAN
	SELECT* FROM HopDongThue WITH(NOLOCK)
	WHERE MaHopDong = @MAHOPDONG AND MaNha = @MANHA AND MaKH = @MAKH
COMMIT TRAN

EXEC SEE_CONTRACT 6, 10, 1


--------TH3----------------
-----------KHÁCH HÀNG XEM DANH SÁCH NHÀ BÁN
CREATE PROC SEE_HOUSE_FOR_SELL
AS
BEGIN TRAN	
	SELECT* FROM NhaBan WITH(NOLOCK)
COMMIT TRAN

EXEC SEE_HOUSE_FOR_SELL 

-----------------------UNREPEATABLE READ------------
------------TH1
---------NHÂN VIÊN CẬP NHẬT TÌNH TRẠNG NHÀ TRÊN ĐƯỜNG
CREATE PROC UPDATE_STATUS_BY_STREET @TINHTRANG CHAR(50), @TENDUONG_NHA CHAR(50)
AS
BEGIN TRAN
	UPDATE Nha SET TinhTrang = @TINHTRANG WHERE TenDuong_Nha = @TENDUONG_NHA
COMMIT TRAN

EXEC UPDATE_STATUS_BY_STREET 'kin', 'Bach Dang'
SELECT TinhTrang FROM Nha WHERE TenDuong_Nha = 'Bach Dang'




-----------TH2
------------KHÁCH HÀNG TÌM DANH SÁCH NHÀ BÁN NHỎ HƠN GIÁ NHẬP VÀO
CREATE PROC FIND_HOUSE_WITH_PRICE @PRICE FLOAT
AS
BEGIN TRAN
	SELECT MaNha, GiaBan FROM NhaBan WHERE GiaBan < @PRICE
	WAITFOR DELAY '00:00:05'
	SELECT* FROM dbo.NhaBan WHERE GiaBan < @PRICE
COMMIT TRAN

EXEC FIND_HOUSE_WITH_PRICE 90000000

----------------------LOST UPDATE--------------------
------------TH1
----------NHÂN VIÊN CẬP NHẬT TÌNH TRẠNG NHÀ--------
ALTER PROC UPDATE_STATUS_01 @MANHA INT, @STATUS CHAR(10)
AS
BEGIN TRAN
	DECLARE @STATUS_HOME CHAR(10)
	SET @STATUS_HOME = (SELECT TinhTrang FROM Nha 
					WHERE MaNha = @MANHA)
	SET @STATUS_HOME = @STATUS
	UPDATE Nha SET TinhTrang = @STATUS_HOME WHERE MaNha = @MANHA
	SELECT MaNha, TinhTrang FROM Nha 
COMMIT TRAN

EXEC UPDATE_STATUS_01 1, 'het han'


---CHẠY PROC TRƯỚC --> TỚI PROC_02
 -------------------PHANTOM------------------
---------TH1
------KHÁCH HÀNG XEM TẤT CẢ HỢP ĐỒNG THUÊ CỦA MÌNH
ALTER PROC SEE_ALL_CONTRACT @MAKH INT
AS
BEGIN TRAN
	SELECT MaNha, MaHopDong FROM HopDongThue WHERE MaKH = @MAKH
	WAITFOR DELAY '00:00:05'
	SELECT* FROM HopDongThue WHERE MaKH = @MAKH
COMMIT TRAN

EXEC SEE_ALL_CONTRACT 3

--------TH2
-------ADMIN THÊM 1 NHÂN VIÊN VÀO CHI NHÁNH
CREATE PROC AddEmployee @IDBranch INT, @name CHAR(50), @add CHAR(100), @sdt CHAR(11), @gender BIT,
			@DoB DATE, @salary FLOAT, @flag BIT, @user CHAR(50), @pass CHAR(50)
AS 
	BEGIN TRAN 
	INSERT INTO dbo.NhanVien
	(MaNV, MaCN, TenNV, DiaChiNV, SDT_NV, GioiTinhNV,
	 NgaySinh, Luong, CurrentFlag, username, password)
	 VALUES((SELECT COUNT(*) FROM dbo.NhanVien) + 1, @IDBranch, @name, @add, @sdt, @gender,
	 @DoB, @salary, @flag, @user, @pass)
	COMMIT TRAN

EXEC AddEmployee  1, 'Van' , 'TPHCM',
'0345613373', 0, '2000-01-17', 230000, 1, 'thh', '123'

-----------------------CONVESION DEADLOCK--------------
-----------TH1
---------NHÂN VIÊN CẬP NHẬT TÌNH TRẠNG NHÀ
CREATE PROC UPDATE_STATUS_01_CONVERSION_DL @MANHA INT, @STATUS01 CHAR(10)
AS
BEGIN TRAN
	SET TRAN ISOLATION LEVEL SERIALIZABLE
	DECLARE @STATUS_HOUSE CHAR(10) = (SELECT TinhTrang FROM Nha 
					WHERE MaNha = @MANHA)
	SET @STATUS_HOUSE = @STATUS01
	UPDATE Nha SET TinhTrang = @STATUS_HOUSE
	WHERE MaNha = @MANHA
COMMIT TRAN

EXEC UPDATE_STATUS_01_CONVERSION_DL 1, 'het han'
SELECT TinhTrang FROM Nha


-----------------------CYCLE DEADLOCK--------------
-------------TH1

CREATE PROC CYCLE_DL_01 @MAKH INT, @MAPHIEU INT, @DIACHI CHAR(100), @TIEUCHI CHAR(100) 
AS
BEGIN TRAN
	UPDATE KhachHang SET DiaChiKH = @DIACHI
	WHERE MaKH = @MAKH

	UPDATE YeuCauKhachHang SET TieuChi = @TIEUCHI
	WHERE MaKH = @MAKH AND MaPhieu = @MAPHIEU

COMMIT TRAN

EXEC CYCLE_DL_01 9, 2, 'Long An', 'co gac'

SELECT NV.username, NV.password
FROM NhanVien NV


alter table ChuNha alter column username varchar(3)
alter table ChuNha alter column  password varchar(3) 

create proc GetCustomerInf @user varchar(3), @pass varchar(3)
as
	select* from KhachHang where username = @user and password = @pass

create proc GetOwnerInf @user varchar(3), @pass varchar(3)
 as
	select* from ChuNha where username = @user and password = @pass

CREATE PROC SignUp_Owner @name CHAR(50), @add CHAR(100), @phone CHAR(11), @user VARCHAR(3), @pass VARCHAR(3)
AS 
	INSERT INTO ChuNha(MaChuNha, TenChuNha, DiaChi_ChuNha, SDT_ChuNha, username, password)
	VALUES ((SELECT COUNT(*) FROM ChuNha) + 1, @name, @add, @phone, @user, @pass)
GO

CREATE PROC SignUp_Customer @name CHAR(50), @add CHAR(100), @phone CHAR(11), @user VARCHAR(3), @pass VARCHAR(3), @nvql INT
AS 
	INSERT INTO KhachHang(MaKH, TenKH, DiaChiKH, SDT_KH, username, password, MaNV)
	VALUES ((SELECT COUNT(*) FROM KhachHang) + 1, @name, @add, @phone, @user, @pass, @nvql)

GO
-- Xem số lượt thuê nhà 
ALTER PROC ViewRentals @MACN INT, @MANHA INT
AS 
	SELECT COUNT(HD.MaNha) AS 'The number of rentals'
	FROM HopDongThue HD, Nha N
	WHERE HD.MaNha = @MANHA AND N.MaChuNha = @MACN AND HD.MaNha = N.MaNha
GO

EXEC ViewRentals 3, 4
GO

CREATE PROC VIEW_RENTAL_HOUSE @MACN INT 
AS 
	SELECT N.*
	FROM Nha N, NhaThue NT
	WHERE N.MaChuNha = @MACN AND N.MaNha = NT.MaNha
GO
EXEC VIEW_RENTAL_HOUSE 3

select * from YeuCauKhachHang