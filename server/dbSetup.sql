-- Active: 1711124626342@@35.87.147.206@3306@patient_sasquatch_480188_db
CREATE TABLE IF NOT EXISTS accounts (
    id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
    createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created', 
    updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update', 
    name varchar(255) COMMENT 'User Name', email varchar(255) COMMENT 'User Email', 
    picture varchar(255) COMMENT 'User Picture'
) default charset utf8mb4 COMMENT '';

CREATE TABLE houses (
    id INT NOT NULL PRIMARY KEY AUTO_INCREMENT, 
    createdAt DATETIME DEFAULT CURRENT_TIMESTAMP, 
    updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP, 
    year SMALLINT UNSIGNED NOT NULL, price MEDIUMINT UNSIGNED DEFAULT 0, 
    imgUrl VARCHAR(1000) NOT NULL, description VARCHAR(500), creatorId VARCHAR(255) NOT NULL, 
    FOREIGN KEY (creatorId) REFERENCES accounts (id) ON DELETE CASCADE
)

DROP TABLE houses;

SELECT id, name FROM accounts;

INSERT INTO
    houses (
        year, price, imgUrl, description, creatorId
    )
VALUES (
        1999, 20000, "https://unsplash.com/photos/red-and-white-house-surround-green-grass-field-eWqOgJ-lfiI", "Red House", "6602f6b35524751e79041b7e"
    );