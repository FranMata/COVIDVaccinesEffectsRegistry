USE COVIDVaccinesEffects
GO

CREATE TABLE Doctor(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	DocumentId INT,
	ProfessionalCode INT,
	Name VARCHAR(150),
	Email VARCHAR(100),
	Country VARCHAR(80),
	Province VARCHAR(80)
);

CREATE TABLE Clinic(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(100),
	TaxId INT,
	Country  VARCHAR(80),
	Province  VARCHAR(80),
	District  VARCHAR(80),
	Phone INT,
	Email  VARCHAR(80),
	Web  VARCHAR(80)
);

CREATE TABLE Patient(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	DocumentId INT,
	Name VARCHAR(80),
	LastName VARCHAR(80),
	BirthDate VARCHAR(80),
	Gender INT,
	ContactNumber INT,
	Country VARCHAR(80),
	Province VARCHAR(80),
	District VARCHAR(80),
	MaritalStatus INT,
	Email VARCHAR(80),
	RegistryDate VARCHAR(80),
	Occupation VARCHAR(80),
	DoctorId INT,
	ClinicId INT,

	FOREIGN KEY (DoctorId) REFERENCES Doctor(Id),
	FOREIGN KEY (ClinicId) REFERENCES Clinic(Id)
);

CREATE TABLE Vaccine(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(80),
	Brand VARCHAR(80),
	AplicationDate VARCHAR(80),
	BatchNumber INT,
	ExpirationDate VARCHAR(80),
	AplicationPlace VARCHAR(80),
	Observations VARCHAR(MAX),
	PatientId INT,

	FOREIGN KEY (PatientId) REFERENCES Patient(Id)
);

CREATE TABLE Answers(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Aswer Varchar(10)
);

CREATE TABLE PatientMedicalHistory(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	HadCOVIDPrevios INT,
	HadSuspicionCOVID INT,
	HadCOVIDAfter INT,
	Reason VARCHAR(MAX),
	IsPregnant INT,
	HadVaccineReaction INT,
	VaccineReactionDescription VARCHAR(MAX),
	ActualMedicine VARCHAR(MAX),
	MedicineAfterCOVIDVeccine VARCHAR(MAX),
	PatientId INT,

	FOREIGN KEY (PatientId) REFERENCES Patient(Id),
	FOREIGN KEY (HadCOVIDPrevios) REFERENCES Answers(Id),
	FOREIGN KEY (HadSuspicionCOVID) REFERENCES Answers(Id),
	FOREIGN KEY (HadCOVIDAfter) REFERENCES Answers(Id),
	FOREIGN KEY (IsPregnant) REFERENCES Answers(Id),
	FOREIGN KEY (HadVaccineReaction) REFERENCES Answers(Id)
);

CREATE TABLE AdverseEffect(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	KeepSymptom INT,
	AllergyDescription VARCHAR(MAX),
	OtherConditions VARCHAR(MAX),
	TypeNewCancer VARCHAR(200),
	PatientId INT,

	FOREIGN KEY (PatientId) REFERENCES Patient(Id),
	FOREIgN KEY (KeepSymptom) REFERENCES Answers(Id)
	
);

CREATE TABLE Allergy(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(100)	
);

CREATE TABLE Symptom(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(100)	
);

CREATE TABLE Disease(
	Id INT IDENTITY(1,1) PRIMARY KEY,
		Name VARCHAR(100)
);

CREATE TABLE AllergyRegistered(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	PatientId INT,
	AllergyId INT,

	FOREIGN KEY (AllergyId) REFERENCES Allergy(Id),
	FOREIGN KEY (PatientId) REFERENCES Patient(Id),
);

CREATE TABLE SymptomRegistered(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	PatientId INT,
	SymptomId INT,

	FOREIGN KEY (SymptomId) REFERENCES Symptom(Id),
	FOREIGN KEY (PatientId) REFERENCES Patient(Id),
);

CREATE TABLE DiseaseRegistered(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	PatientId INT,
	DeseaseId INT,

	FOREIGN KEY (DeseaseId) REFERENCES Disease(Id),
	FOREIGN KEY (PatientId) REFERENCES Patient(Id),
);