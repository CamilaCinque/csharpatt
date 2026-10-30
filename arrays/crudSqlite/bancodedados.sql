-- DDL, DML, DQL
	-- 	DDL - data definition language (CREATE, DROP, ALTER)
	-- 	DML - data manipulation language (INSERT, UPDATE, DELETE)
	-- 	DQL - data query language (SELECT)

select * from frutas;

-- 	DML - INSERT
INSERT INTO frutas(nomeFruta)
VALUES
("banana");

-- 	DML - UPDATE
UPDATE frutas SET nomeFruta = 'uva' WHERE nomeFruta == 'banana'

-- 	DML - DELETE
DELETE FROM frutas 
WHERE nome == 'manga';



