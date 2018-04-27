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
	IDNV varchar(10) ,
	IDDOOR varchar(10),
	TIME_USE time,
	DATE_USE date,
	Primary Key (IDNV,IDDOOR),
	foreign key (IDDOOR) references DOOR(IDDOOR)
)

create table USR
(
	ID varchar(10) primary key,
	PASS varchar(20)
)

create table REPORT
(
	TimeDo smalldatetime,
	Task varchar(200)
)

CREATE TABLE Time_Template
(
	[Id] varchar(30) NOT NULL PRIMARY KEY, 
    [Start_Time] TIME NOT NULL, 
    [End_Time] TIME NOT NULL
)
