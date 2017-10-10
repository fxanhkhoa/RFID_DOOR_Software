create table DOOR
(
	IDDOOR varchar(10) primary key,
	VITRI varchar(50),
	DOOR_STATUS varchar(4)
)

create table NHANVIEN
(
	IDNV varchar(10) primary key,
	TEN varchar(30),
	DONVI varchar(30)
)

create table SUDUNG
(
	IDNV varchar(10) primary key,
	IDDOOR varchar(10),
	TIME_USE time,
	DATE_USE date,
	foreign key (IDDOOR) references DOOR(IDDOOR)
)

create table USR
(
	ID varchar(10) primary key,
	PASS varchar(20)
)