--QUERY LABORATORIO PICHARDO_GONZALEZ
CREATE DATABASE LaboratorioPichardoGonzalez;
GO
USE LaboratorioPichardoGonzalez;
GO
CREATE TABLE PACIENTE
	(ID_PACIENTE INT IDENTITY(1,1) NOT NULL,
	 NOMBRE VARCHAR(100),
	 DIRECCION VARCHAR(50),
	 LOCALIDAD VARCHAR(30),
	 PROVINCIA VARCHAR(30),
	 TELEFONO VARCHAR(15),
	 TELEFONO2 VARCHAR(15),
	 CEDULA_PAC VARCHAR(13),
	 FECHA_INGRESO DATE,
	 EDAD INT,
	 FECHA_NACIMIENTO DATE,
	 SEXO CHAR(1),
	 EMAIL VARCHAR(30),
	 NUMERO_POLIZA INT,
	 SEGURO VARCHAR(30),
	 TIPO_PERSONA VARCHAR(30),
	 CONSTRAINT PK_PAC PRIMARY KEY(ID_PACIENTE)
	);
GO
CREATE TABLE DEPARTAMENTO
	(ID_DEPARTAMENTO INT IDENTITY(1,1) NOT NULL,
	 DESC_DEP VARCHAR(100),
	 CONSTRAINT PK_DEP PRIMARY KEY(ID_DEPARTAMENTO)
	);
GO
CREATE TABLE SEGURO
	(ID_SEGURO INT IDENTITY(1,1) NOT NULL,
	 DESC_SEG VARCHAR(100),
	 CONSTRAINT PK_SEG PRIMARY KEY(ID_SEGURO)
	);
GO
CREATE TABLE REGISTRO_PRUEBAS
	(ID_PRUEBA INT NOT NULL,
	 ID_DEPARTAMENTO INT NOT NULL,
	 DESC_PRUEBA VARCHAR(100),
	 --DETALLE VARCHAR(300),
	 UNIDADES VARCHAR(20),
	 VALOR_MIN VARCHAR(20),
	 VALOR_MAX VARCHAR(20),
	 COSTO_CLIENTE INT,
	 CONSTRAINT PK_PRUE PRIMARY KEY(ID_PRUEBA),
	 CONSTRAINT FK_PRUE FOREIGN KEY(ID_DEPARTAMENTO) REFERENCES DEPARTAMENTO(ID_DEPARTAMENTO)
	);
GO
CREATE TABLE PRECIO
	(ID_PRECIO INT NOT NULL,
	 ID_DEPARTAMENTO INT NOT NULL,
	 ID_PRUEBA INT NOT NULL,
	 ID_SEGURO INT NOT NULL,
	 PRECIO_CLIENTE INT,
	 PRECIO_SEGURO INT,
	 CONSTRAINT PK_PREC PRIMARY KEY(ID_PRECIO),
	 CONSTRAINT FK_PREC2 FOREIGN KEY(ID_DEPARTAMENTO) REFERENCES DEPARTAMENTO(ID_DEPARTAMENTO),
	 CONSTRAINT FK_PREC3 FOREIGN KEY(ID_SEGURO) REFERENCES SEGURO(ID_SEGURO),
	 CONSTRAINT FK_PREC4 FOREIGN KEY(ID_PRUEBA) REFERENCES REGISTRO_PRUEBAS(ID_PRUEBA)
	);
GO
CREATE TABLE FACTURACION
	(ID_RECORD INT NOT NULL,
	 ID_PACIENTE INT NOT NULL,
	 ID_DEPARTAMENTO INT NOT NULL,
	 ID_PRUEBA INT NOT NULL,
	 ID_PRECIO INT,
	 CONSTRAINT PK_FAC PRIMARY KEY(ID_RECORD),
	 CONSTRAINT FK_FAC FOREIGN KEY(ID_PACIENTE) REFERENCES PACIENTE(ID_PACIENTE),
	 CONSTRAINT FK_FAC2 FOREIGN KEY(ID_DEPARTAMENTO) REFERENCES DEPARTAMENTO(ID_DEPARTAMENTO),
	 CONSTRAINT FK_FAC3 FOREIGN KEY(ID_PRUEBA) REFERENCES REGISTRO_PRUEBAS(ID_PRUEBA),
	 CONSTRAINT FK_FAC4 FOREIGN KEY(ID_PRECIO) REFERENCES PRECIO(ID_PRECIO)
	);
GO
CREATE TABLE RESULTADOS
	(ID_RESULTADO INT NOT NULL,
	 ID_RECORD INT NOT NULL,
	 FECHA_RESULT DATE,
	 DETALLE VARCHAR(300),
	 RESULTADO VARCHAR(100),
	 BACILOSCOPIA VARCHAR(300),
	 DOCTOR VARCHAR(50),
	 COMENTARIO VARCHAR(300),
	 CONSTRAINT PK_RES PRIMARY KEY(ID_RESULTADO),
	 CONSTRAINT FK_RES FOREIGN KEY(ID_RECORD) REFERENCES FACTURACION(ID_RECORD)
	);
GO
CREATE TABLE ANTIBIOGRAMA
	(ID_ANTIBIOGRAMA INT NOT NULL,
	 ID_RESULTADOS INT NOT NULL,
	 ANTIBIOTICO VARCHAR(20),
	 RESULTADO VARCHAR(15),
	 CONSTRAINT PK_ANT PRIMARY KEY(ID_ANTIBIOGRAMA),
	 CONSTRAINT FK_ANT FOREIGN KEY(ID_RESULTADOS) REFERENCES RESULTADOS(ID_RESULTADO)
	);
GO
CREATE TABLE ORGANISMOS
	(ID_ORGANISMOS INT NOT NULL,
	 ID_ANTIBIOGRAMA INT NOT NULL,
	 ORGANISMO_AISLADO VARCHAR(30), --TRUE OR FALSE
	 ORGANISMO1 VARCHAR(50),
	 ORGANISMO2 VARCHAR(50),
	 CONSTRAINT PK_ORG PRIMARY KEY(ID_ORGANISMOS),
	 CONSTRAINT FK_ORG FOREIGN KEY(ID_ANTIBIOGRAMA) REFERENCES ANTIBIOGRAMA(ID_ANTIBIOGRAMA),
	);
GO
CREATE TABLE USUARIOS
	(ID_USUARIO INT NOT NULL,
	 NOMBRE VARCHAR(30),
	 USUARIO VARCHAR(15),
	 CONTRASENA VARCHAR(20),
	 PERMISOS VARCHAR(100),
	 CONSTRAINT PK_US PRIMARY KEY(ID_USUARIO)
	);
--HOLA--
