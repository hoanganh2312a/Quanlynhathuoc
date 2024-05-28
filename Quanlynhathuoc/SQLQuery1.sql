Create database QLBT
go
use QLBT
go
create table TaiKhoan(
	TaiKhoan varchar(50) not null PRIMARY KEY,
	MatKhau varchar(50),
	HoTen nvarchar(100),
	NgayTao date,
	ChucVu nvarchar(100)
)
create table NhomThuoc(
	maNhom varchar(50) not null primary key,
	tenNhom nvarchar(100),
	ghiChu nvarchar(100)
)
create table Thuoc(
	iDThuoc varchar(50) not null primary key,
	maThuoc nvarchar(100),
	tenThuoc nvarchar(50),
	maNhom varchar(50),
	nguonGoc nvarchar(100),
	maNSX varchar(50),
	soLuong int,
	giaBan float,
	maDVT varchar(50),
	thanhPhan nvarchar(500),
	hamluong nvarchar(500),
	congDung nvarchar(500),
	phanTacDung nvarchar(500),
	cachDung nvarchar(500),
	chuY nvarchar(500),
	hanSuDung nvarchar(500),
	baoQuan nvarchar(500),
	dangBaoChe nvarchar(500)
)
create table NhaSanXuat(
	maNSX varchar(50) not null primary key,
	tenNSX	nvarchar(100),
	diaChi nvarchar(200),
	dienThoai nvarchar(100),
	email nvarchar(100)
)
create table DonViTinh(
	maDVT varchar(50) not null primary key,
	tenDVT nvarchar(50)
)
create table BenhNhan(
	idBN varchar(50) not null primary key,
	hoTen nvarchar(50),
	tuoi int,
	diaChi nvarchar(500),
	dienThoai nvarchar(50)
)
create table NhaPhanPhoi(
	maNPP varchar(50) not null primary key,
	tenNPP nvarchar(100),
	diaChi nvarchar(200),
	dienThoai nvarchar(100),
	email nvarchar(100),
	maSoThue nvarchar(100),
	ghiChu nvarchar(200)
)
create table HoaDonNhap(
	maHDN varchar(50) not null primary key,
	maNPP varchar(50),
	nguoiGiao nvarchar(50),
	nguoiNhan nvarchar(50),
	tongTienThuoc float,
	tongThue float,
	tongTienHD float,
	ngayViet datetime,
	ngayNhap datetime
)
create table HoaDonXuat(
	maHDX varchar(50) not null primary key,
	idBN varchar(50),
	tongTienThuoc float,
	ngayLap datetime,
	tongThue float,
	tongTienHD float
)
create table chiTietHoaDonNhap(
	maCTHDN varchar(50) not null primary key,
	maHDN varchar(50),
	idThuoc varchar(50),
	soLuong int,
	giaNhap float
)
create table chiTietHoaDonXuat(
	maCTHDX varchar(50) not null primary key,
	maHDX varchar(50),
	idThuoc varchar(50),
	soLuong int,
	giaBan float,
	thue float,
	donVi nvarchar(50)
)
go
alter table Thuoc
add constraint FK_Thuoc_NhomThuoc foreign key (maNhom)
references NhomThuoc(maNhom)
alter table Thuoc
add constraint FK_Thuoc_NSX foreign key (maNSX)
references NhaSanXuat(maNSX)
alter table Thuoc
add constraint FK_Thuoc_DonViTinh foreign key (maDVT)
references DonViTinh(maDVT)
alter table HoaDonNhap
add constraint FK_HoaDonNhap_NhaPhanPhoi foreign key (maNPP)
references NhaPhanPhoi(maNPP)
alter table chiTietHoaDonNhap
add constraint FK_ChiTietHoaDonNhap_HoaDonNhap foreign key (maHDN)
references HoaDonNhap(maHDN)
alter table ChiTietHoaDonNhap
add constraint FK_ChiTietHoaDonNhap_Thuoc foreign key (idThuoc)
references Thuoc(idThuoc)
alter table ChiTietHoaDonXuat
add constraint FK_ChiTietHoaDonXuat_HoaDonXuat foreign key (maHDX)
references HoaDonXuat(maHDX)
alter table ChiTietHoaDonXuat
add constraint FK_ChiTietHoaDonXuat_Thuoc foreign key (idThuoc)
references Thuoc(idThuoc)
alter table HoaDonXuat
add constraint FK_HoaDonXuat_BenhNhan foreign key (idBN)
references BenhNhan(idBN)
go
insert into NhomThuoc
values('123456',N'ngoài da' ,N'không dùng cho trẻ em'),
	('234567',N' kháng sinh' ,N'không dùng trước khi ăn'),
	('345678',N'chống dị ứng' ,N'không dùng vào buổi tối'),
	('456789',N'dạ dày' ,N'dùng sau khi ăn'),
	('987654',N'tiêu hóa' ,N'dùng sau khi có triệu chứng'),
	('876543',N'nhỏ mắt' ,N'nhỏ trực tiếp'),
	('102345',N'thực phẩm chức năng' ,N'không thay thế thuốc'),
	('012345',N'huyết áp tim mạch' ,N'không dùng cho trẻ em')
	
insert into NhaSanXuat
values('123',N'traphaco',' 75 Yên Ninh, Phường Quán Thánh, Quận Ba Đình, Hà Nội.','0123456789','traphaco@gmail.com'),
('456',N'PYMEPHARCO',' 166 – 170 Nguyễn Huệ, Tuy Hòa, Phú Yên','025 7382 9165','hcns@pymepharco.com'),
('789',N'Imexpharm',' Số 4, Đường 30/4, Phường 1, TP Cao Lãnh, Đồng Tháp','027 7385 1941','vpcty@domesco.com'),
('897',N'DOMESCO',' 66 Quốc lộ 30, Mỹ Phú, Cao Lãnh, Đồng Tháp',' 027 7385 1270','domesco@domesco.com')
insert into DonViTinh
values('1234',N'lọ'),
	('2345',N'vỹ'),
	('3456',N'tuýt'),
	('4567',N'xịt'),
	('5678',N'bịch')

insert into BenhNhan
values('987',N'Lê Văn Hoàn',23,N'62b/1 lê hồng phong Quận 1','0897654456'),
('876',N'Nguyễn văn tí ',25,N'12/1 lê văn việt Quận Thủ Dức','0897646856'),
('765',N'Trần Dần',43,N'25a Nguyễn Xuyển Quận Thủ Đức','038924875'),
('654',N'Nguyễn Hữu Việt',18,N'37b/2/1 Võ Thị Sáu Quận 10','08984356'),
('321',N'Đặng Thành Đạt',31,N'14a Nguyễn Duy Trinh Quận 2','089765456'),
('432',N'Lê văn Cường',19,N'67c/1 Võ Văn Kiệt Quận 1','025854456')
insert into NhaPhanPhoi
values('631',N'giathuochapu',N'Số 62 ngõ 6 đường Vũ Trọng Phụng, phường Thanh Xuân Trung, quận Thanh Xuân, Hà Nội','0878.898.222','giathuochapu@gmail.com','5%','không có ghi chú'),
('632',N'giathuocsi',N'134/1 Tô Hiến Thành, Phường 15, Quận 10, Tp Hồ Chí Minh, Việt Nam','0355 24 6868','Giathuocsi@gmail.com','3%','không có ghi chú'),
('633',N'thuocsi',N'số 36, quầy B1, 134/1 Tô Hiến Thành, P. 15, Q.10, Tp. HCM','0936.276.830 ','medipharmaq10@gmail.com','4%','không có ghi chú')
insert into Thuoc
values('11111','T001',N'Paracetamol','234567',N'Mỹ','123',10,'23000','2345',N'nhóm hydroxyl và nguyên tử nitơ','80/125/250/500/650mg',N'hạ sốt,đau đầu',N'khó ngủ',N'dùng với nước',N'không dùng với người chưa đủ 8 tuổi',N'6 tháng so với NSX',N'nơi khô ráo',N'bột pha trẻ em(hapacol), siro, thuốc viên'),
('12222','T002',N'enterogermina','987654',N'Mỹ','456',3,'50000','5678',N'Bacillus Clausii',N'2 tỷ/5ml với thành phần mỗi ống 5ml',N'kiểm soát hệ tiêu hóa',N'đắng',N'dùng trực tiếp',N'không dùng với người chưa đủ 10 tuổi',N'12 tháng so với NSX',N'nơi khô ráo',N'lỏng'),
('13333','T003',N'Mupirocin','123456',N'Mỹ','789',1,'47000','3456',N'20 mg mupirocin (2% w/w mupirocin axit tự do)',N'Thuốc mỡ bôi ngoài da: 2%, tuýp 15 g, 30 g, 60 g',N'ngừa vết thâm',N'lâu có hiệu quả',N'bôi trực tiếp',N'không dùng với người chưa đủ 8 tuổi',N'6 tháng so với NSX',N'nơi khô ráo',N'thuốc bôi'),
('14444','T004',N'Amlodipin','012345',N'Mỹ','123',10,'30000','2345',N'Tinh bột mì, Microcrystallin cellulose PH102, Magnesi stearat, Nang cứng gelatin số 4',N'Viên nén: 2,5 mg, 5 mg, 10 mg amlodipin',N'cân bằng huyết áp',N'khó ngủ',N'dùng với nước',N'không dùng với người chưa đủ 18 tuổi',N'6 tháng so với NSX',N'nơi khô ráo',N'thuốc viên'),
('15555','T005',N'Neodex','876543',N'Mỹ','897',1,'53000','1234',N'Dexamethasone Natri (5.5mg). Neomycin Sulfate (25mg)','25mg',N'sáng mắt',N'chảy nước mắt',N'nhỏ trực tiếp',N'không dùng với người chưa đủ 8 tuổi',N'6 tháng so với NSX',N'nơi khô ráo',N'lỏng')
insert into HoaDonNhap
values('531','631','GHTK',N'Lê Thị Huyền',3000000,125000,2975000,'3-2-2024','5-3-2024'),
('532','633','Ngô Phúc Hưng',N'Đào Quang Anh',2000000,105000,1975000,'9-3-2024','11-3-2024'),
('533','632','Mai Thùy Anh',N'Nguyễn An Diệp',1200000,96000,1144000,'6-6-2024','5-7-2024'),
('534','631','Trần Thanh Hà',N'Lê Hoài An',900000,115000,821000,'4-2-2024','5-3-2024'),
('535','633','Hà Anh Tuấn',N'Đinh Tùng Anh',2200000,122000,2210000,'11-2-2024','3-5-2024'),
('536','632','Chu Bá Quân',N'Lê Thùy Linh',500000,164000,4300000,'8-6-2024','12-7-2024'),
('537','631','Nguyễn Quốc Duy',N'Trân Văn Khoa',3200000,178000,2975000,'6-8-2024','8-8-2024')
insert into HoaDonXuat
values('944','987',50000,'5-2-2024',10000,40000),
('943','765',100000,'10-3-2024',15000,85000),
('945','654',90000,'12-6-2024',13000,77000),
('946','321',55000,'12-12-2024',7000,48000),
('947','876',60000,'8-8-2024',8000,52000)
insert into chiTietHoaDonNhap
values('471','531','11111',5,1200000),
('472','532','12222',4,2200000),
('473','533','13333',3,2000000)
insert into chiTietHoaDonXuat
values('911','944','13333',5,1200000,10000,'đồng')
insert into TaiKhoan
values('1','1','1','5/14/2024','admin')
go
create proc sp_inHoaDonBN(@idBN varchar(50))
as
select bn.hoTen,diaChi,dienThoai,hdx.idBN,tongTienHD,tongThue,ngayLap,cthdx.soLuong,cthdx.giaBan,th.giaBan,tenThuoc
from (((HoaDonXuat hdx join BenhNhan bn on hdx.idBN = bn.idBN) join ChiTietHoaDonXuat cthdx on hdx.maHDX = cthdx.maHDX) join Thuoc th on cthdx.idThuoc=th.iDThuoc)
where bn.idBN = @idBN

go
create proc sp_inHoaDonNhap(@maHDN varchar(50))
as
select cthdn.maHDN,cthdn.soLuong,giaNhap,cthdn.idThuoc,npp.tenNPP,th.tenThuoc
from (((HoaDonNhap hdn join NhaPhanPhoi npp on hdn.maNPP = npp.maNPP) join chiTietHoaDonNhap cthdn on hdn.maHDN = cthdn.maHDN) join Thuoc th on cthdn.idThuoc=th.iDThuoc)
where hdn.maHDN=@maHDN

--insert into BenhNhan
--values(3,'1',1 ,'1' ,'1')
--insert into TaiKhoan
--values('3','1',1 ,'5/14/2024' ,'admin')
--go
--create proc reportHoaDonXuat
--as select HoaDonXuat.maHDX, hoTen, Thuoc.tenThuoc, chiTietHoaDonXuat.soLuong
--from HoaDonXuat, BenhNhan, chiTietHoaDonXuat, Thuoc
--where HoaDonXuat.idBN = BenhNhan.idBN and HoaDonXuat.maHDX = chiTietHoaDonXuat.maHDX and Thuoc.iDThuoc = chiTietHoaDonXuat.idThuoc
