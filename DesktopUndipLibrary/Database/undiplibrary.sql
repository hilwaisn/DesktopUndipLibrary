CREATE DATABASE UndipLibrary;
USE UndipLibrary;

CREATE TABLE Admin(
	Username VARCHAR(10),
	Passwordd VARCHAR(10)
);

CREATE TABLE Anggota(
	IdAnggota VARCHAR(12) PRIMARY KEY,
	Nama VARCHAR(40),
	ProgramStudi VARCHAR(45),
	TempatLahir VARCHAR(20),
	TanggalLahir DATE,
	NomorTelepon INT (13),
	Alamat VARCHAR (50)
);

CREATE TABLE Rak(
	Id VARCHAR(2) PRIMARY KEY,
	Nama VARCHAR(4)
);

CREATE TABLE KoleksiBuku(
	Id VARCHAR(4) PRIMARY KEY,
	Nama VARCHAR(10)
);

CREATE TABLE Buku(
	IdBuku VARCHAR(5) PRIMARY KEY,
	Judul VARCHAR(100),
	Pengarang VARCHAR(50),
	TahunTerbit INT(4),
	Stok INT (3),
	IdKoleksi VARCHAR(4),
	IdRak VARCHAR(2)
);

CREATE TABLE Peminjaman(
	Id VARCHAR(5) PRIMARY KEY,
	TanggalPinjam DATE,
	TanggalKembali DATE,
	IdAnggota VARCHAR(12),
	IdBuku VARCHAR(5)
);

CREATE TABLE Pengunjung(
	Id VARCHAR(5) PRIMARY KEY,
	Nama VARCHAR(50),
	JenisKelamin VARCHAR(10),
	ProgramStudi VARCHAR(45),
	Keperluan VARCHAR(10),
	Cari VARCHAR(10),
	Tanggal	DATE,
	Jam TIME
);
