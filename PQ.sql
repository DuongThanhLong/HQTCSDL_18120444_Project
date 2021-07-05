--ALTER PROC SIGN_IN_EMPLOYEE @MACN INT, @TENNV CHAR(50), 
--							@DIACHINV CHAR(100), @SDT_NV CHAR(11), @GIOITINHNV BIT,
--							@NGAYSINH DATE, @SALARY FLOAT, 
--							@USERNAME CHAR(50), @PASSWORD CHAR(50)
--AS
--BEGIN
--	DECLARE @MANV INT
--	SET @MANV = (SELECT MAX(MANV) FROM [dbo].[NhanVien]) + 1
--	IF(EXISTS(SELECT * FROM [dbo].[NhanVien] WHERE USERNAME = @USERNAME))
--	BEGIN
--		PRINT(N'USER HAS EXISTSED')
--		RETURN
--	END
--	ELSE
--	BEGIN
--		INSERT INTO [dbo].[NhanVien] (MANV, MACN, TENNV, DIACHINV, SDT_NV, GIOITINHNV, NGAYSINH, LUONG, CURRENTFLAG, USERNAME, PASSWORD)
--		VALUES (@MANV, @MACN, @TENNV, @DIACHINV, @SDT_NV, @GIOITINHNV, @NGAYSINH, @SALARY, 1, @USERNAME, @PASSWORD);
--	END
--	declare @us char(50) -- username
--	set @us = (select USERNAME from NHANVIEN where MANV = @MANV)
--	declare @pw char(50) --password
--	set @pw = (select PASSWORD from NHANVIEN where MANV = @MANV)
--	exec sp_addlogin @us , @pw
--	--create user nv111 for login [nv11                                              ]
--	exec sp_grantdbaccess @us, @us

--	exec sp_addrolemember Employee, @us
--END

--exec SIGN_IN_EMPLOYEE 3,'Test1','ssssssssss','2152425',1,null,5248,'nv11','11'

--role ADMIN
exec sp_addrole db_ADMIN 
exec sp_addlogin 'admin','admin'
create user dbadmin for login admin
exec sp_addsrvrolemember 'admin', [sysadmin]
--grant insert on NhanVien to dbadmin

--role Employee
exec sp_addrole Employee
grant insert on	[dbo].[HopDongThue] to Employee
grant update on [dbo].[NhaBan](GiaBan) to Employee
grant update on [dbo].[Nha](TinhTrang) to Employee

exec sp_addlogin 'Emp1','1'
create user Emp1 for login Emp1
exec sp_addrolemember Employee, Emp1

-- role Seller
exec sp_addrole Seller
grant select on [dbo].[LSDangNha] to Seller
grant select on [dbo].[LSXemNha] to Seller
grant select on [dbo].[Nha] to Seller
grant select on [dbo].[NhaBan] to Seller
grant select on [dbo].[NhaThue] to Seller

exec sp_addlogin 'Seller1','1'
create user Seller1 for login Seller1
exec sp_addrolemember Seller, Seller1

-- role Customer
exec sp_addrole Customer 
grant select on [dbo].[HopDongThue] to Customer
grant select on [dbo].[NhanVien] to Customer
grant select on [dbo].[NhaBan] to Customer
grant select on [dbo].[Nha] to Customer

exec sp_addlogin 'KH01','1'
create user KH01 for login KH01
exec sp_addrolemember Customer, KH01