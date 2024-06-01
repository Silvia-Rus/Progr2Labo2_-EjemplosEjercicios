
CREATE DATABASE BIBLIOTECA_EJ;

CREATE TABLE USUARIOS (
    ID int NOT NULL AUTO_INCREMENT,
    nombre varchar(255) NOT NULL,
    DNI varchar(255) NOT NULL,
    PRIMARY KEY (ID)
);

CREATE TABLE OBRAS (
    ID int NOT NULL AUTO_INCREMENT,
    titulo varchar(255) NOT NULL,
    autor varchar(255) NOT NULL,
    anio varchar(255) NOT NULL,
    barcode varchar(255) NOT NULL,
    duracion varchar(255),
    numPaginas varchar(255),
    tipo varchar(255) NOT NULL,
    PRIMARY KEY (ID)
);

CREATE TABLE PRESTAMOS (
    ID int NOT NULL AUTO_INCREMENT,
    idUsuario int NOT NULL,
    idObra int NOT NULL,
    fechaPrestamo datetime NOT NULL,
    fechaDevolucion datetime,
    PRIMARY key (ID),
    FOREIGN KEY (idUsuario) REFERENCES USUARIOS(ID),
    FOREIGN KEY (idObra) REFERENCES OBRAS(ID)
)

INSERT INTO USUARIOS (nombre, DNI)
VALUES 
('Rus, Silvia', '95418871'),
('Pérez, Pepe', '95418872');


INSERT INTO OBRAS (titulo, autor, anio, barcode, numPaginas, tipo)
VALUES 
('La casa de Bernarda Alba', 'García Lorca, Federico', 1997, '12345', 97, 'libro'),
('Yerma',  'García Lorca, Federico', 2000, '12346', 100, 'libro'),
('Martín Fierro', 'Hernández, José', 2005, '12347', 200, 'libro');


DELETE FROM OBRAS
WHERE barcode = '12345';

UPDATE USUARIOS
SET nombre = 'Rus Mata, Silvia'
WHERE DNI = '95418871';

SELECT *
FROM OBRAS
WHERE OBRAS.barcode = '12346';

SELECT OBRAS.titulo
FROM OBRAS
WHERE OBRAS.anio > 2000;