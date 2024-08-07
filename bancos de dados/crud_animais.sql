CREATE DATABASE crud_animais;

CREATE TABLE animal(
	nome_animal VARCHAR(100) NULL,
	especie_animal VARCHAR(100) NULL,
	patas_animal VARCHAR(100) NULL,
	genero_animal VARCHAR(100) NULL,
	codigo_animal INTEGER PRIMARY KEY AUTO_INCREMENT
);