CREATE TABLE admins (
    AdminID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    password VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL,
    firstname VARCHAR(100) NOT NULL,
    secondname VARCHAR(100) NOT NULL,
    phoneno VARCHAR(15) NOT NULL
);

CREATE TABLE members (
    userid INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    firstname VARCHAR(100) NOT NULL,
    secondname VARCHAR(100) NOT NULL,
    phoneno VARCHAR(15) NOT NULL,
    address VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL,
    AdminID INT NOT NULL,
    password VARCHAR(255) ,
    FOREIGN KEY (AdminID) REFERENCES admins   (AdminID));

	CREATE TABLE Books (
    ISBN varchar(20) NOT NULL PRIMARY KEY,
    Title VARCHAR(255) NOT NULL,
    Author VARCHAR(255),
    Publisher VARCHAR(255) ,
    Category VARCHAR(100) ,
    Status VARCHAR(50) ,
    CopiesAvailable INT ,
    AdminID INT ,
    Price DECIMAL(10, 4) NOT NULL,
    FOREIGN KEY (AdminID) REFERENCES admins (AdminID));


	CREATE TABLE Borrowing (
    userid INT NOT NULL,
    ISBN varchar(20) NOT NULL,
    borrow_date DATE NOT NULL,
    due_date DATETIME NOT NULL,
    return_date DATE ,
    fine DECIMAL(18, 2),
    PRIMARY KEY (userid, ISBN) ,
	foreign key (userid) references  members(userid),
    foreign key (ISBN) references  Books (ISBN));

	CREATE TABLE Reservations (
    userid INT NOT NULL,
    ISBN varchar(20) NOT NULL,
    resevation_date DATETIME NOT NULL,
    bookstate  VARCHAR(50)  NULL,
    PRIMARY KEY (userid, ISBN) ,
	foreign key (userid) references  members(userid),
    foreign key (ISBN) references  Books (ISBN));
	


