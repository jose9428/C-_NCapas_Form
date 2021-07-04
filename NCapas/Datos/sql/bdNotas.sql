USE MASTER
-- CREACION DE BASE DE DATOS  (DATA y LOG)
USE master
go

SET  DATEFORMAT DMY
IF EXISTS(SELECT * FROM sys.sysdatabases WHERE name='bdnotas')
	DROP DATABASE bdnotas

CREATE DATABASE bdnotas
GO

USE bdnotas
go

-- Verificando la existencia de las tablas
-- ---------------------------------------
SET DATEFORMAT DMY
GO

IF EXISTS ( SELECT name FROM sys.sysobjects
   WHERE type = 'U' AND name = 'alumno' )
   DROP TABLE alumno
go

IF EXISTS ( SELECT name FROM sys.sysobjects
   WHERE type = 'U' AND name = 'PAGOS' )
   DROP TABLE PAGOS
go

IF EXISTS ( SELECT name FROM sys.sysobjects
   WHERE type = 'U' AND name = 'especialidad' )
   DROP TABLE especialidad
go


-- Creación de las Tablas y Claves Primarias
-- -----------------------------------------

CREATE TABLE Alumno (
       IdAlumno             char(5) NOT NULL primary key,
       ApeAlumno            varchar(30) NOT NULL,
       NomAlumno            varchar(30) NOT NULL,
       Idesp                char(3) NOT NULL,
       proce                char(1) 
)
go

CREATE TABLE PAGOS (
       IdAlumno             char(5) NOT NULL ,
       Ciclo                char(6) NOT NULL,
       nCuota               INT NOT NULL,
       Monto                NUMERIC(12,2) NOT NULL,
      Fecha                 DATETIME,
     PRIMARY KEY(IDALUMNO, CICLO, NCUOTA) 
    )
go




CREATE TABLE especialidad (
       Idesp          char(3) NOT NULL PRIMAry key,
       Nomesp         varchar(30) NOT NULL,
       costo          numeric(8,1) not null
       )
go



CREATE TABLE Curso (
       IdCurso              char(4) NOT NULL primary key,
       NomCurso             varchar(35) NOT NULL,
       credito              int 
)
go

go


CREATE TABLE NOTAS (
       IdAlumno             char(5) NOT NULL,
       IdCurso              char(4) NOT NULL,
       ExaParcial           real NULL,
       ExaFinal             real NULL,
       primary key(Idalumno,Idcurso)
)
go

SET DATEFORMAT DMY
GO

Insert Into Especialidad Values('E01','Educacion Informatica',2500)
Insert Into Especialidad Values('E02','Administracion',1800)
Insert Into Especialidad Values('E03','Contabilidad',2000)
Insert Into Especialidad Values('E04','Idiomas',1800)
Insert Into Especialidad Values('E05','Ing. de Sistemas',2800)


Insert Into ALUMNO Values('A0001','Valencia salcedo','Christian','E01','N')
Insert Into ALUMNO Values('A0002','Ortiz Rodriguez','Freddy','E01','P')
Insert Into ALUMNO Values('A0003','Silva Mejia','Ruth Ketty','E02','N')
Insert Into ALUMNO Values('A0004','Melendez Noriega','Liliana','E03','P')
Insert Into ALUMNO Values('A0005','Huerta Leon','Silvia','E04','N')
Insert Into ALUMNO Values('A0006','Carranza Fuentes','Maria Elena','E02','P')
Insert Into ALUMNO Values('A0007','Prado Castro','Gabriela','E01','N')
Insert Into ALUMNO Values('A0008','Atuncar Mesias','Juan','E05','P')
Insert Into ALUMNO Values('A0009','Aguilar Zavala','Patricia Elena','E01','P')
Insert Into ALUMNO Values('A0010','Rodruigez Trujillo','Rubén Eduardo','E01','N')
Insert Into ALUMNO Values('A0011','Canales Ruiz','Gino Leonel','E02','P')
Insert Into ALUMNO Values('A0012','Ruiz Quispe','Edgar','E02','N')
Insert Into ALUMNO Values('A0013','PanduroTerrazas','Omar','E03','P')
Insert Into ALUMNO Values('A0014','Zita Padilla','Peter Wilmer','E03','N')
Insert Into ALUMNO Values('A0015','Ternero Ubillús','Luis','E05','P')
Insert Into ALUMNO Values('A0016','Rivera García','Raúl Joel','E04','P')
Insert Into ALUMNO Values('A0017','Pomar García','Ana','E04','P')
Insert Into ALUMNO Values('A0018','Palomares Venegas','Mercedes','E04','N')
Insert Into ALUMNO Values('A0019','Ruiz Venegaz','Luis Alberto','E04','P')
Insert Into ALUMNO Values('A0020','Tejada Bernal','Janet','E04','P')
Insert Into ALUMNO Values('A0021','Sotelo Canales','Juan Carlos','E05','P')
Insert Into ALUMNO Values('A0022','LLosa Montalvan','Karla','E05','P')
Insert Into ALUMNO Values('A0023','Galarza Torres','Hugo','E03','P')
Insert Into ALUMNO Values('A0024','Valverde Jaramillo','Saul','E05','N')
Insert Into ALUMNO Values('A0025','Cipriano Avila','Roxana','E04','N')
Insert Into ALUMNO Values('A0026','Rodriguez Quispe','Luis Alberto','E05','P')
Insert Into ALUMNO Values('A0027','Huerta Leon','Marco Antonio','E05','N')
Insert Into ALUMNO Values('A0028','Ortiz Fuentes','Ana María','E04','P')
Insert Into ALUMNO Values('A0029','Rivera Jaramillo','Martha','E05','P')
Insert Into ALUMNO Values('A0030','Bustamante Campos','Guino','E05','N')

--  PAGOS   CORRESPONDIENTES

Insert Into PAGOS Values('A0001','2017-2',1,300,  '10/10/16')
Insert Into PAGOS Values('A0001','2017-2',2,340,  '11/11/16')
Insert Into PAGOS Values('A0001','2017-1',3,340,  '12/12/16')
Insert Into PAGOS Values('A0002','2016-2',1,300,  '10/05/16')
Insert Into PAGOS Values('A0002','2016-2',2,350,  '11/05/16')
Insert Into PAGOS Values('A0002','2016-1',1,360,  '12/05/16')
Insert Into PAGOS Values('A0002','2016-1',2,370,  '11/05/16')

Insert Into PAGOS Values('A0003','2017-1',1,340,'11/06/16')
Insert Into PAGOS Values('A0003','2017-1',2,340,'12/07/16')
Insert Into PAGOS Values('A0003','2017-2',1,340,'11/05/16')

Insert Into PAGOS Values('A0004','2017-2',1,300,'03/09/16')
Insert Into PAGOS Values('A0004','2017-2',2,380,'01/10/16')
Insert Into PAGOS Values('A0004','2016-1',1,370,'11/05/16')

Insert Into PAGOS Values('A0005','2017-2',1,350,'11/10/16')
Insert Into PAGOS Values('A0005','2017-2',2,360,'11/08/16')
Insert Into PAGOS Values('A0005','2016-1',1,380,'09/05/16')

Insert Into PAGOS Values('A0006','2017-2',3,300,'13/09/16')
Insert Into PAGOS Values('A0006','2017-1',1,340,'11/03/16')
Insert Into PAGOS Values('A0006','2017-1',2,390,'11/05/16')

Insert Into PAGOS Values('A0007','2017-2',1,340,'11/06/16')
Insert Into PAGOS Values('A0007','2017-1',1,380,'11/05/16')
Insert Into PAGOS Values('A0007','2017-1',2,440,'11/06/16')

Insert Into PAGOS Values('A0008','2017-2',1,340,'11/08/17')
Insert Into PAGOS Values('A0008','2017-2',2,320,'11/09/17')
Insert Into PAGOS Values('A0008','2016-1',1,370,'11/02/17')

Insert Into PAGOS Values('A0009','2017-2',1,340,'11/06/17')
Insert Into PAGOS Values('A0009','2017-2',2,330,'11/07/17')
Insert Into PAGOS Values('A0009','2017-1',1,340,'11/05/17')

Insert Into PAGOS Values('A0010','2017-2',1,340,'13/07/17')
Insert Into PAGOS Values('A0010','2017-2',2,330,'11/09/17')
Insert Into PAGOS Values('A0010','2017-1',1,350,'11/06/17')

Insert Into PAGOS Values('A0011','2017-2',1,340,'11/06/17')
Insert Into PAGOS Values('A0011','2017-2',2,330,'11/08/17')
Insert Into PAGOS Values('A0011','2017-1',2,370,'11/06/17')

Insert Into PAGOS Values('A0012','2017-2',1,340,'11/08/17')
Insert Into PAGOS Values('A0012','2017-2',2,370,'11/09/17')
Insert Into PAGOS Values('A0012','2017-1',1,390,'15/08/17')

Insert Into PAGOS Values('A0013','2017-2',1,340,'11/06/17')
Insert Into PAGOS Values('A0013','2017-1',1,340,'11/05/17')
Insert Into PAGOS Values('A0013','2017-1',2,350,'11/05/17')
Insert Into PAGOS Values('A0013','2017-1',3,370,'11/06/17')

Insert Into PAGOS Values('A0014','2017-2',1,340,'11/10/17')
Insert Into PAGOS Values('A0014','2017-2',2,330,'11/11/17')
Insert Into PAGOS Values('A0014','2017-1',1,350,'11/05/17')


Insert Into PAGOS Values('A0016','2017-2',1,340,'11/09/17')
Insert Into PAGOS Values('A0016','2017-2',2,360,'11/10/17')
Insert Into PAGOS Values('A0016','2017-1',1,340,'11/05/17')

Insert Into PAGOS Values('A0021','2017-2',1,340,'11/07/17')
Insert Into PAGOS Values('A0021','2017-2',2,480,'10/08/17')
Insert Into PAGOS Values('A0021','2017-1',1,340,'10/05/17')

Insert Into PAGOS Values('A0022','2017-2',1,340,'11/08/17')
Insert Into PAGOS Values('A0022','2017-2',2,330,'11/09/17')
Insert Into PAGOS Values('A0022','2017-1',1,350,'11/03/17')

Insert Into PAGOS Values('A0023','2017-2',1,340,'11/09/17')
Insert Into PAGOS Values('A0023','2017-2',2,370,'11/10/17')
Insert Into PAGOS Values('A0023','2017-1',1,370,'11/05/17')

Insert Into PAGOS Values('A0024','2017-2',1,340,'11/06/17')
Insert Into PAGOS Values('A0024','2017-2',2,340,'11/08/17')
Insert Into PAGOS Values('A0024','2017-1',1,340,'11/05/17')
Insert Into PAGOS Values('A0024','2017-1',2,340,'11/05/17')

Insert Into PAGOS Values('A0025','2017-2',1,340,'11/08/17')
Insert Into PAGOS Values('A0025','2017-2',2,370,'11/09/17')

Insert Into PAGOS Values('A0028','2017-1',1,340,'11/05/17')
Insert Into PAGOS Values('A0028','2013-1',2,390,'11/06/17')

Insert Into PAGOS Values('A0029','2016-1',1,340,'11/06/17')

-- Agregar Datos a la Tabla NOTAS
-- ===============================

Insert Into NOTAS Values('A0001','C001',11,17)
Insert Into NOTAS Values('A0001','C003',09,15)
Insert Into NOTAS Values('A0001','C004',18,3)
Insert Into NOTAS Values('A0002','C001',15,9)
Insert Into NOTAS Values('A0002','C002',11,03)
Insert Into NOTAS Values('A0002','C003',14,13)
Insert Into NOTAS Values('A0003','C008',12,13)
Insert Into NOTAS Values('A0003','C005',16,14)
Insert Into NOTAS Values('A0003','C003',8,13)
Insert Into NOTAS Values('A0003','C004',7,14)
Insert Into NOTAS Values('A0004','C006',11,12)
Insert Into NOTAS Values('A0004','C007',9,11)
Insert Into NOTAS Values('A0004','C005',7,12)
Insert Into NOTAS Values('A0005','C004',17,16)
Insert Into NOTAS Values('A0005','C005',12,17)
Insert Into NOTAS Values('A0005','C003',6,13)
Insert Into NOTAS Values('A0006','C004',16,15)
Insert Into NOTAS Values('A0006','C006',5,12)
Insert Into NOTAS Values('A0006','C007',8,13)
Insert Into NOTAS Values('A0007','C002',7,9)
Insert Into NOTAS Values('A0007','C004',12,7)
Insert Into NOTAS Values('A0007','C005',11,6)
Insert Into NOTAS Values('A0008','C008',5,8)
Insert Into NOTAS Values('A0008','C009',7,4)
Insert Into NOTAS Values('A0008','C004',5,13)
Insert Into NOTAS Values('A0009','C005',6,13)
Insert Into NOTAS Values('A0009','C009',18,13)
Insert Into NOTAS Values('A0009','C010',12,15)
Insert Into NOTAS Values('A0010','C010',16,14)
Insert Into NOTAS Values('A0010','C001',5,12)
Insert Into NOTAS Values('A0010','C003',12,11)
Insert Into NOTAS Values('A0011','C001',5,13)
Insert Into NOTAS Values('A0011','C002',11,13)
Insert Into NOTAS Values('A0011','C004',7,03)
Insert Into NOTAS Values('A0012','C004',10,08)
Insert Into NOTAS Values('A0012','C005',7,10)
Insert Into NOTAS Values('A0012','C006',17,10)
Insert Into NOTAS Values('A0013','C001',14,3)
Insert Into NOTAS Values('A0013','C002',7,10)
Insert Into NOTAS Values('A0013','C004',12,13)
Insert Into NOTAS Values('A0013','C003',15,12)
Insert Into NOTAS Values('A0014','C001',11,15)
Insert Into NOTAS Values('A0014','C003',15,13)
Insert Into NOTAS Values('A0014','C004',12,18)
Insert Into NOTAS Values('A0015','C001',5,13)
Insert Into NOTAS Values('A0015','C003',14,13)
Insert Into NOTAS Values('A0015','C004',15,12)

Insert Into NOTAS Values('A0016','C002',6,13)
Insert Into NOTAS Values('A0016','C003',12,11)
Insert Into NOTAS Values('A0016','C006',17,12)

Insert Into NOTAS Values('A0021','C004',8,17)
Insert Into NOTAS Values('A0021','C005',14,3)
Insert Into NOTAS Values('A0021','C006',17,12)

Insert Into NOTAS Values('A0022','C004',17,13)
Insert Into NOTAS Values('A0022','C005',8,13)
Insert Into NOTAS Values('A0022','C003',7,13)

Insert Into NOTAS Values('A0023','C004',10,13)
Insert Into NOTAS Values('A0023','C008',12,13)
Insert Into NOTAS Values('A0023','C009',18,13)

Insert Into NOTAS Values('A0024','C004',10,3)
Insert Into NOTAS Values('A0024','C005',11,9)
Insert Into NOTAS Values('A0024','C003',16,8)
Insert Into NOTAS Values('A0024','C007',16,13)

Insert Into NOTAS Values('A0025','C004',1,13)
Insert Into NOTAS Values('A0025','C005',10,18)

Insert Into NOTAS Values('A0028','C005',16,13)
Insert Into NOTAS Values('A0028','C004',17,7)

Insert Into NOTAS Values('A0029','C004',11,13)

-- Agragar Datos a la Tabla Curso
-- ==============================

Insert Into Curso Values('C001','Matematica Basica',3)
Insert Into Curso Values('C002','Filosofia I',6)
Insert Into Curso Values('C003','Psicologia Industrial',5)
Insert Into Curso Values('C004','Algoritmica',4)
Insert Into Curso Values('C005','Software de Aplicacion',5)
Insert Into Curso Values('C006','Lenguaje de Programacion I',5)
Insert Into Curso Values('C007','Lenguaje Java ',4)
Insert Into Curso Values('C008','Matematica II',3)
Insert Into Curso Values('C009','Ingles Tecnico',5)
Insert Into Curso Values('C010','Lenguaje de Programacion III',3)
Insert Into Curso Values('C011','Aplicaciones Cliente/Servidor',4)

alter table alumno add constraint r1 foreign key (idesp) references especialidad(idesp)

alter table notas add constraint r2 foreign key (idalumno) references alumno(idalumno)

alter table notas add constraint r3 foreign key (idcurso) references curso(idcurso)



SELECT * FROM ALUMNO
SELECT * FROM ESPECIALIDAD
SELECT * FROM PAGOS
SELECT * FROM NOTAS
SELECT * FROM CURSO


create procedure sp_listarPagos(@idAlu char(5))
as
begin
 select Ciclo , nCuota , Monto , FORMAT(fecha, 'dd/MM/yyyy') as [fecha]
 from PAGOS where IdAlumno = @idAlu
end
go

Create PROCEDURE spadiAlu
(@ape varchar(30),@nom varchar(30),@es char(3), @pro char(1))
as
begin
	declare @coda char(5)
	declare @cuenta int
	select @cuenta=right(max(idalumno),4)+1 from alumno
	set @coda='A'+ right('000'+ltrim(@cuenta),4)
	insert into alumno values(@coda, @ape,@nom,@es,@pro)
end


-- execute sp_listarPagos 'A0001'
