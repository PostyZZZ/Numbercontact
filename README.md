БД в postgre
Создать бд и таблицу в ней: 
CREATE TABLE contact (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255),
    phone_number VARCHAR(20)
);
заменить строку подключения 
