drop database controlresidencias;

create database ControlResidencias;
use controlResidencias;

create table carrera(
	ID		int		primary key auto_increment,
    Nombre	varchar(50)		not null
);

create table docente(
	ID			char(9)		primary key,
    Nombre		varchar(50)	not null,
    ApellidoP	varchar(50) not null,
    ApellidoM	varchar(50) not null,
    Correo		varchar(50) not null,
    Telefono	varchar(10) null,
    Carrera		int		not null,
    Usuario		varchar(50)	not null,
    Password	varchar(50) not null,
    Estatus		enum('Activo','Inactivo'),
    constraint foreign key(Carrera) references carrera(ID)
);

create table alumno(
	Matricula	char(9)		 primary key,
    Password	varchar(6)	 not null,
    Nombre		varchar(50)	 not null,
    ApellidoP	varchar(50)  not null,
    ApellidoM	varchar(50)  not null,
    Correo		varchar(50)  not null,
    Domicilio   varchar(150) not null,
    Ciudad      varchar(50)  not null,
    Telefono	varchar(10)  null,
    Carrera		int		     not null,
    Semestre	smallint	not null,
    TipoSS		enum('IMSS','ISSSTE','Otro'),
    NumeroSS	varchar(20)	null,
	Estatus		enum('Activo','Inactivo'),
    constraint foreign key(Carrera) references carrera(ID)
);

create table rolDocente(
	IdAlumno	char(9)		not null,
    IdDocente	char(9)		not null,
    Rol			enum('Coordinador','Asesor','Revisor','Academia','Administrador'),
    constraint foreign key(IdAlumno) references alumno(Matricula),
    constraint foreign key(IdDocente) references docente(ID),
    constraint primary key(IdAlumno,IdDocente)
);

create table empresa(
	RFC			char(13)		primary key,
    Nombre		varchar(50)		not null,
    Giro		enum('Industrial','Servicios','Otro'),
    Sector		enum('Publico','Privado'),
    Domicilio	varchar(50)		not null,
    Colonia		varchar(30)		not null,
    Ciudad		varchar(50)		not null,
    CP			char(5)			not null,
    Telefono	varchar(10)		null,
    Fax			varchar(12)		null,
    Mision		varchar(50)		null,
    Titular		varchar(80)		not null,
    PuestoTitu	varchar(50)		null
);

create table InfoResidencia(
	ID				int				auto_increment	primary key,
    NombreProyecto	varchar(50)		not null,
    Modalidad		enum('Banco de proyectos','Propuesta propia','Trabajador'),
    Periodo			enum('ENE-JUN','AGO-DIC'),
    Anio			int				not null,
    AsesorExt		varchar(80)		not null,
    PuestoAsesor	varchar(30)		null,
    Responsable		varchar(80)		not null,
    PuestoRespo		varchar(30)		null,
    IdEmpresa		varchar(15)		not null,
    IdAlumno		char(9)			not null,
	constraint foreign key(IdAlumno) references alumno(Matricula),
    constraint foreign key(IdEmpresa) references empresa(RFC)
);

create table dictamen(
	ID				int				auto_increment	primary key,
    IdResidencia	int				not null,
    IdDocente		char(9)			not null,
    Tipo			enum('LiberacionAsesor','LiberacionFinal','LiberacionRevisor','AprobacionAsesor','AprobacionRevisor'),
    Estatus			enum('Aceptado','Rechazado')	null,
    Comentario		text(150)		null,
    Calificacion	int				null,
    Fecha			date			not null,
    constraint foreign key(IdDocente) references docente(ID),
    constraint foreign key(IdResidencia) references InfoResidencia(ID)
);

create table documento(
	id		int 		auto_increment	primary key,
    nombre	varchar(30)	not null
);

create table entregaDocumento(
	idAlumno	char(9)	not null,
    idDocumento	int		not null,
    estado		enum('Entregado','Pendiente'),
    constraint primary key(idAlumno,idDocumento),
    constraint foreign key(idAlumno) references alumno(Matricula),
	constraint foreign key(idDocumento) references documento(ID)
);

create table solicitud(
	id				int		auto_increment	primary key,
    idAlumno		char(9)	not null,
    idResidencia	int 	not null,
    Estatus         enum('Aceptado','Pendiente'),
	constraint foreign key(IdResidencia) references InfoResidencia(ID),
    constraint foreign key(idAlumno) references alumno(Matricula)
);


insert into carrera(Nombre) values
('Ing. Sistemas Computacionales'),
('Ing. Gestión Empresarial'),
('Ing. Electrónica'),
('Ing. Ambiental'),
('Ing. Sistemas Automotrices'),
('Ing. Industrial'),
('Lic. Gastronomía');

insert into alumno values
('S19650897','1234','José','Moreno','Díaz','asdf@gmail.com','Comonfot #89','Moroleón','4409463879',1,7,'IMSS','3456787456','Activo'),
('D09643879','1234','Andrea','Zavala','López','oohjf@hotmail.com','Zaragoza #8099','Uriangato','4450978346',2,8,'ISSSTE','985675878798','Inactivo'),
('I06753980','1234','Miguel','Torres','Flores','asdf@live.com,mx','Benito Juarez #97A','Yuriria','4097250899',3,8,'Otro','91247529875','Activo');

insert into docente values
('S18790740','Luis Germán','Gutierrez','Torres','lic.german@itsur.edu.mx','4450967391',1,'GermanGT','1234','Activo'),
('I87012394','Lourdes','López','Tinoco','l.lopez@itsur.edu.mx','4493375164',2,'LourdesLT','1234','Activo'),
('D91361288','Adrian','Bonal','Mora','a.bonal@itsur.edu.mx','9184023861',3,'AdrianBM','1234','Inactivo'),
('S67150249','Nancy Carolina','Quintana','Martínez','nc.quintana@itsur.edu.mx','4423879284',1,'NancyQM','1234','Activo'),
('I19823741','Francisco','Campos','Lozano','f.campos@itsur.edu.mx','4428348249',2,'FranciscoCL','1234','Activo'),
('D18741973','Miranda','Espinoza','Mireles','m.espinoza@itsur.edu.mx','8912378169',3,'MirandaEM','1234','Inactivo');

insert into rolDocente values
('S19650897','S18790740','Asesor'),
('S19650897','S67150249','Revisor'),
('S19650897','I87012394','Revisor'),
('D09643879','D91361288','Asesor'),
('D09643879','D18741973','Revisor'),
('D09643879','S18790740','Revisor'),
('I06753980','I87012394','Asesor'),
('I06753980','I19823741','Revisor'),
('I06753980','D91361288','Revisor');

insert into empresa values
('KGHINDOPHJK98','Loop Jeans','Industrial','Privado','Hidalgo #68','Centro','Moroleón','38800','4450912387',null,'Lorem Ipsum','Ignacio Rosiles','CEO'),
('AKSJDFHAKSS70','Nuevo mundo','Servicios','Privado','Victoria #1897','Progreso','Uriangato','39876','4451817392',null,'Lorem Ipsum','Dulce García','Jefa de operaciones'),
('IOAEJDHAOIN12','Secundaria Técnica','Otro','Publico','Dalia #289A','Juan Lucas','Yuriria','82346','9126343082',null,'Lorem Ipsum','Cándido Días','Director');

insert into infoResidencia values
(null,'Tejiendo Web','Propuesta propia','ENE-JUN',2016,'Arturo Cuevas','Dpto. Informática','Aurora Rosiles','Recursos Humanos','AKSJDFHAKSS70','S19650897'),
(null,'Impresora laser','Banco de proyectos','ENE-JUN',2017,'Juan Escutia','Dpto. Manufactura','Georgina Serna','Contadora','KGHINDOPHJK98','I06753980'),
(null,'Sistema de inventario','Trabajador','AGO-DIC',2016,'Ericka Romro','Dpto. Contraloria','Gonzalo Camarena','Recursos Humanos','IOAEJDHAOIN12','D09643879');

insert into dictamen values
(null,1,'S18790740','LiberacionAsesor','Aceptado','Revisar la introducción',null,'2016-03-11'),
(null,1,'S67150249','LiberacionRevisor','Aceptado','Revisar la ortografía',null,'2016-03-11'),
(null,1,'I87012394','LiberacionRevisor','Aceptado','Bien ejecutado',null,'2016-03-12'),
(null,3,'D18741973','LiberacionRevisor','Rechazado','El proyecto no cumple con los aspectos necesarios',null,'2016-10-01'),
(null,2,'I87012394','LiberacionAsesor','Aceptado','Lorem ipsum dolor sit amet',null,'2017-04-30'),
(null,2,'I19823741','LiberacionRevisor','Aceptado',null,null,'2017-05-01'),
(null,2,'D91361288','LiberacionRevisor','Rechazado','Lorem ipsum',null,'2017-05-02'),
(null,2,'I87012394','LiberacionFinal','Aceptado',null,87,'2017-05-22');

insert into documento values
(null,'Solicitud de residencias'),
(null,'Carta de aceptación'),
(null, 'Cronograma de actividades'),
(null, 'Informe'),
(null, 'Resumen ejecutivo'),
(null, 'CD'),
(null, 'Asesorias'),
(null, 'Documento de evaluación');

insert into entregaDocumento values
('S19650897',1,'Entregado'),
('S19650897',2,'Entregado'),
('D09643879',1,'Entregado'),
('D09643879',2,'Pendiente'),
('I06753980',1,'Pendiente'),
('I06753980',2,'Pendiente');

insert into solicitud values
(null,'S19650897',1,'Aceptado'),
(null,'D09643879',3,'Pendiente'),
(null,'I06753980',2,'Pendiente');