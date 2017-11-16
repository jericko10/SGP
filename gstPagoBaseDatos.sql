create database gstPago
go

use gstPago

create table gstALMpAlumno(
ALMcodigo int identity(1,1) not null,
ALMdni char(8) not null,
ALMnombre varchar(250) not null,
ALMapellido varchar(250) not null,
ALMobservacion varchar(250),
ALMperiodo int not null,
ALMnivel varchar(15) not null,
ALMgrado int not null,
ALMseccion varchar(1) not null,
ALMestado varchar(20) not null,
primary key (ALMcodigo)
)

create table gstUSUpUsuario(
USUcodigo int identity(1,1) not null,
USUdni char(8) not null,
USUnombre varchar(250) not null,
USUapellido varchar(250) not null,
USUcontrasena varchar(20) not null,
USUperiodo int not null,
USUnivel varchar(15) not null,
USUgrado int not null,
USUseccion varchar(1) not null,
USUestado varchar(20) not null,
USUtipo varchar(15) not null
primary key (USUcodigo)
)

create table gstCONpConcepto(
CONcodigo int identity(1,1) not null,
CONdescripcion varchar(250) not null,
CONmonto decimal(6,2) not null,
CONtipo varchar(20) not null,
primary key (CONcodigo)
)

create table gstCUOtCuota(
CUOcodigo int identity(1,1) not null,
CONcodigo int not null,
CUOano date not null,
CUOmes varchar(15) not null,
CUOperiodo varchar(30) not null,
CUOalcance varchar(30) not null,
primary key (CUOcodigo),
foreign key(CONcodigo) references gstCONpConcepto
)

create table gstDEUtDeuda(
DEUcodigo int identity(1,1) not null,
ALMcodigo int not null,
CUOcodigo int not null,
DEUmonto decimal(6,2) not null,
DEUdescripcion varchar(250) not null,
primary key (DEUcodigo),
foreign key(ALMcodigo) references gstALMpAlumno,
foreign key(CUOcodigo) references gstCUOtCuota
)

create table gstFRAtFraccion(
FRAcodigo int identity(1,1) not null,
CUOcodigo int not null,
ALMcodigo int not null,
primary key (FRAcodigo),
foreign key(ALMcodigo) references gstALMpAlumno
)

create table gstEXOtExoneracion(
EXOcodigo int identity(1,1) not null,
DEUcodigo int not null,
EXOmotivo varchar(100) not null,
EXOdescripcion varchar(250),
primary key (EXOcodigo),
foreign key(DEUcodigo) references gstDEUtDeuda
)

create table gstRECtRecibo(
RECcodigo char(10) not null,
ALMcodigo int not null,
USUcodigo int not null,
RECfecha date not null,
RECtotal decimal(6,2) not null,
primary key (RECcodigo),
foreign key(ALMcodigo) references gstALMpAlumno,
foreign key(USUcodigo) references gstUSUpUsuario
)

create table gstDPGtDeudaPago(
DPGcodigo int identity(1,1) not null,
RECcodigo char(10) not null,
DEUcodigo int not null,
DPGsubtotal decimal (6,2) not null,
primary key (DPGcodigo),
foreign key(RECcodigo) references gstRECtRecibo,
foreign key(DEUcodigo) references gstDEUtDeuda
)