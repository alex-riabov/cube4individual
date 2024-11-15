-- Create the 'Locations' table
CREATE TABLE Locations (
    id INT AUTO_INCREMENT PRIMARY KEY,
    city VARCHAR(50) NOT NULL
);

-- Create the 'Services' table
CREATE TABLE Services (
    id INT AUTO_INCREMENT PRIMARY KEY,
    service_name VARCHAR(50) NOT NULL
);

-- Create the 'Employees' table
CREATE TABLE Employees (
    id INT AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    fixed_phone VARCHAR(15),
    mobile_phone VARCHAR(15),
    email VARCHAR(50) UNIQUE,
    service_id INT,
    location_id INT,
    FOREIGN KEY (service_id) REFERENCES Services(id),
    FOREIGN KEY (location_id) REFERENCES Locations(id)
);
