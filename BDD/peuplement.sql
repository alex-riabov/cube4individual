-- Populate the 'sites' table
INSERT INTO sites (city) VALUES 
('Paris'), 
('Nantes'), 
('Toulouse'), 
('Nice'), 
('Lille');

-- Populate the 'services' table
INSERT INTO services (service_name) VALUES 
('Comptabilité'), 
('Production'), 
('Accueil'), 
('Informatique'), 
('Commercial');

-- Populate the 'employees' table
INSERT INTO employees (first_name, last_name, fixed_phone, mobile_phone, email, service_id, site_id) VALUES 
('Jean', 'Dupont', '0123456789', '0712345678', 'jean.dupont@example.com', 1, 1),
('Marie', 'Martin', '0987654321', '0787654321', 'marie.martin@example.com', 2, 2),
('Paul', 'Durand', '0112233445', '0798765432', 'paul.durand@example.com', 3, 3),
('Sophie', 'Lefèvre', '0192837465', '0765432198', 'sophie.lefevre@example.com', 4, 4),
('Michel', 'Moreau', '0123456780', '0754321987', 'michel.moreau@example.com', 5, 5);
