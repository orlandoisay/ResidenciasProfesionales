drop database controlresidencias;

create database ControlResidencias;

use controlResidencias;

create table carrera(
	ID		int		primary key,
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
    Tipo			enum('LiberacionAsesor','LiberacionFinal','LiberacionRevisor'),
    Estatus			enum('Aceptado','Rechazado')	null,
    Comentario		text(150)		not null,
    Calificacion	int	null,
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