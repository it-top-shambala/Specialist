-- CREATE DATABASE sprecialist_db;
-- CREATE SCHEMA test;
-- SET search_path test;

CREATE TABLE users (
    id SERIAL NOT NULL UNIQUE PRIMARY KEY,
    info_id INTEGER NOT NULL,
    email TEXT NOT NULL CHECK ( email != '' ) UNIQUE,
    password TEXT NOT NULL CHECK ( password !='' ),
    description TEXT NOT NULL CHECK ( description !='' ),
    education TEXT NOT NULL CHECK ( education !='' ),
    practice TEXT NOT NULL CHECK ( practice !='' ),
    status_id INTEGER NOT NULL,
    FOREIGN KEY (status_id) REFERENCES statuses(id)
);

CREATE TABLE info_user (
    id INTEGER NOT NULL UNIQUE PRIMARY KEY,
    name TEXT NOT NULL CHECK ( name !='' ),
    last_name TEXT NOT NULL CHECK ( last_name !='' ),
    sex TEXT,
    birthday DATE,
    phone TEXT UNIQUE,
    FOREIGN KEY (id) REFERENCES users(info_id)
);

CREATE TABLE roles (
    id SERIAL NOT NULL UNIQUE PRIMARY KEY,
    name_role TEXT NOT NULL
);

CREATE TABLE role_users (
    user_id INTEGER NOT NULL PRIMARY KEY,
    role_id INTEGER NOT NULL PRIMARY KEY,
    FOREIGN KEY (user_id) REFERENCES users(id),
    FOREIGN KEY(role_id) REFERENCES roles(id)
);

CREATE TABLE statuses (
    id SERIAL NOT NULL UNIQUE PRIMARY KEY,
    name TEXT NOT NULL CHECK ( name !='' )
);

--вставка данных в таблицу статусов
INSERT INTO statuses (name) VALUES ('active');
INSERT INTO statuses (name) VALUES ('deactivate');
INSERT INTO statuses (name) VALUES ('frozen');
--вставка данных в таблицу ролей
INSERT INTO roles (name_role) VALUES ('admin');
INSERT INTO roles (name_role) VALUES ('user');
INSERT INTO roles (name_role) VALUES ('guest');
