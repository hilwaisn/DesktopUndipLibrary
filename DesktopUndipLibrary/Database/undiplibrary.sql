CREATE DATABASE UndipLibrary;
USE UndipLibrary;

CREATE TABLE Admin(
	Username VARCHAR(10),
	Passwordd VARCHAR(10) PRIMARY KEY
);

CREATE TABLE Member(
	MemberId VARCHAR(12) PRIMARY KEY,
	Namee VARCHAR(45),
	StudyProgram VARCHAR(45),
	PlaceofBirth VARCHAR(50),
	DateofBirth DATE,
	TelephoneNumber VARCHAR(13),
	Address VARCHAR (50)
);

CREATE TABLE Rack(
	Id VARCHAR(2) PRIMARY KEY,
	Namee VARCHAR(4)
);

CREATE TABLE BookCollection(
	Id VARCHAR(4) PRIMARY KEY,
	Namee VARCHAR(10)
);

CREATE TABLE Book(
	BookId VARCHAR(5) PRIMARY KEY,
	Title VARCHAR(100),
	Author VARCHAR(50),
	IssueYear INT(4),
	Stock INT (3),
	CollectionId VARCHAR(4),
	ShelfId VARCHAR(2),
	CONSTRAINT FOREIGN KEY (CollectionId) REFERENCES BookCollection(Id),
	CONSTRAINT FOREIGN KEY (ShelfId) REFERENCES Rack(Id)
);

CREATE TABLE Transactionn(
	Id VARCHAR(5) PRIMARY KEY,
	LoanDate DATE,
	ReturnDate DATE,
	Namee VARCHAR(45),
	MemberId VARCHAR(12),
	BookId VARCHAR(5),
	Information VARCHAR(13),
	CONSTRAINT FOREIGN KEY (MemberId) REFERENCES Member(MemberId),
	CONSTRAINT FOREIGN KEY (BookId) REFERENCES Book(BookId)
);

CREATE TABLE Visitors(
	Id VARCHAR(5) PRIMARY KEY,
	Namee VARCHAR(50),
	Gender VARCHAR(2),
	StudyProgram VARCHAR(45),
	Needs VARCHAR(10),
	Search VARCHAR(10),
	Datee DATE
);

INSERT INTO Admin VALUES ('hilwahhh','123456'),('olaa','000000'),('hilwaisn','170845');

INSERT INTO Member VALUES ('01022211000','Hilwa Isnaini Marfuah','S1-Akuntansi','Kabupaten Semarang','2004-03-15','083861250068','Sejambu'),
('01022311001','Namira Afian Fadila','S1-Perbankan','Kota Salatiga','2004-02-28','082241573268','Kecandran'),
('01022311002','Ayunda Riz`rack`ky Suryanto','S1-Perbankan','Kota Salatiga','2004-08-30','085865554402','Tingkir'),
('02042211008','Fadilah Aulia Muthmainah','S1-Teknik Mesin','Kota Kebumen','2004-10-22','085865554402','Kebumen'),
('01022211001','Nur Jamilah','S1-Akuntansi','Kabupaten Bandung Barat','2004-10-25','083854426758','Cimahi'),
('01022311003','Kuni Fathiyatul Mubarokah','S1-Perbankan','Kota Salatiga','2004-04-20','081809460983','Argomulyo');

INSERT INTO Rack VALUES ('01','R001'),
('02','R002'),
('03','R003'),
('04','R004'),
('05','R005'),
('06','R006');

INSERT INTO BookCollection VALUES ('A001','Ekonomi'),
('A002','Geografi'),
('A003','Sosiologi'),
('A004','Sejarah'),
('B001','Biologi'),
('B002','Kimia'),
('B003','Fisika'),
('C001','Matematika'),
('D001','Psikologi'),
('E001','Religi');

INSERT INTO Book VALUES ('02023','Pengantar Akuntansi','Abdul Hafiz Tanjung',2001,10,'A001','06'),
('01012','Anatomi Tubuh Manusia','Irfiyah Firoroh',2012,5,'B001','05'),
('01030','Sejarah Candi Borobudur','Jilla Arum',2020,8,'A004','06');

INSERT INTO Visitors VALUES ('V0001','Aditya Chandra Prasetya','M','S1-Teknik Informatika','Belajar','Buku','2023-12-02'),
('V0002','Rizo Pranata','M','S1-Teknik Industri','Belajar','Buku','2023-12-02');