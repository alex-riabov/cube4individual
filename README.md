# Cube 4 – Company Directory Desktop App  
WinForms / .NET 8 phone-book for a growing, multi-site French food-industry company (school project).

## What it does
| Role | Capabilities |
|------|--------------|
| **Visitor** | Search employees by _surname substring_, _site_ or _service_ • View the full employee card (fixed & mobile phone, e-mail, service, site) |
| **Administrator** | Hidden entry (press **Ctrl + Alt + A**) → password prompt → CRUD on **Sites**, **Services**, **Employees** with referential-integrity checks (cannot delete a site or service still referenced by employees) |


## Tech stack
| Layer        | Details |
|--------------|---------|
| Desktop UI   | C# · WinForms (.NET 8, single-file publish possible) |
| Data access  | MySqlConnector (`MySql.Data`) |
| Database     | MySQL 8 - scripts in **BDD/** (`create_tables.sql`, `populate.sql`) |
| OS support   | Windows 10/11 |
