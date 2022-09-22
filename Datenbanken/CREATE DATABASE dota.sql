CREATE DATABASE dota;

CREATE TABLE player
(
    pid INT(5) PRIMARY KEY,
    name VARCHAR(10),
    forename VARCHAR(10),
    country VARCHAR(15),
    birth DATE
);

CREATE TABLE heroes
(
    hid INT(5) PRIMARY KEY,
    hero VARCHAR(20)
);

CREATE TABLE teams
(
    tid INT(5) PRIMARY KEY,
    team VARCHAR(20),
    prizes FLOAT(10,2),
    captain INT(5),
    FOREIGN KEY (captain)
    REFERENCES player(PID)
);

CREATE TABLE gamestats
(
    pid INT(5) PRIMARY KEY,
    id VARCHAR(10),
    tid INT(5),
    won INT(5),
    lost INT(5),
    hid INT(5),
    FOREIGN KEY (pid) REFERENCES player(PID),
    FOREIGN KEY (tid) REFERENCES teams(TID),
    FOREIGN KEY (hid) REFERENCES heroes(HID)
);

CREATE TABLE penalties
(
    pnid INT(5),
    points INT(5),
    pid INT(5),
    FOREIGN KEY (pid) 
    REFERENCES player(PID)
);


INSERT INTO player VALUES ( 8, 'Sosale', 'Samantha', 'United States', '2004-04-14');
INSERT INTO player VALUES ( 6, 'Litt-Bin', 'Chan', 'Malaysia', '2001-12-04');
INSERT INTO player VALUES ( 13, 'Kang', 'Thomas', 'China', '2001-04-29');
INSERT INTO player VALUES ( 2, 'Akterhall', 'Joakim', 'Sweden', '2002-03-28');
INSERT INTO player VALUES ( 12, 'Luo', 'Fei Chi', 'China', '2002-10-12');
INSERT INTO player VALUES ( 1, 'Lundkvitz', 'Jerry', 'Sweden', '2000-12-04');
INSERT INTO player VALUES ( 14, 'Price', 'Andrew', 'New Zealand', '2000-03-12');
INSERT INTO player VALUES ( 20, 'Cook', 'Tyler', 'Canada', '2004-11-02');
INSERT INTO player VALUES ( 7, 'Yong', NULL, 'Malaysia', '2004-08-22');
INSERT INTO player VALUES ( 10, 'Broecker', 'Max', 'Germany', '2003-02-23');
INSERT INTO player VALUES ( 5, 'Lille', 'Per', 'Finland', '2004-05-09');
INSERT INTO player VALUES ( 3, 'Berg', 'Sylvia', 'Finland', '1999-08-03');
INSERT INTO heroes VALUES ( 71, 'Chen');
INSERT INTO heroes VALUES ( 72, 'Clockwerk');
INSERT INTO heroes VALUES ( 73, 'Crystal Maiden');
INSERT INTO heroes VALUES ( 74, 'Enchantress');
INSERT INTO heroes VALUES ( 75, 'Gyrocopter');
INSERT INTO heroes VALUES ( 76, 'Keeper of the Light');
INSERT INTO heroes VALUES ( 77, 'Nature''s Prophet');
INSERT INTO heroes VALUES ( 78, 'Terrorblade');
INSERT INTO heroes VALUES ( 79, 'Tinker');
INSERT INTO teams VALUES ( 1, 'The Alliance', 443300, 1);
INSERT INTO teams VALUES ( 2, 'Neolution Orange', 646000, 6);
INSERT INTO teams VALUES ( 3, 'Team Liquid', 49000, 8);
INSERT INTO teams VALUES ( 4, 'Invictus Gaming', 959000, 14);
INSERT INTO gamestats VALUES ( 1, 'EGM', 1, 1, 2, 71);
INSERT INTO gamestats VALUES ( 2, 'AKKE', 1, 1, 2, 74);
INSERT INTO gamestats VALUES ( 3, 'LODA', 1, 2, 3, 73);
INSERT INTO gamestats VALUES ( 5, 'PAKATT', 2, 1, 2, 76);
INSERT INTO gamestats VALUES ( 6, 'WINTER', 2, 7, 1, 79);
INSERT INTO gamestats VALUES ( 7, 'SHARKY', 2, 5, 2, 72);
INSERT INTO gamestats VALUES ( 8, 'BULBA', 3, 2, 5, 77);
INSERT INTO gamestats VALUES ( 20, 'TC', 3, 2, 2, 75);
INSERT INTO gamestats VALUES ( 10, 'QUO', 3, 3, 2, 78);
INSERT INTO gamestats VALUES ( 12, 'FERRA', 4, 5, 8, 73);
INSERT INTO gamestats VALUES ( 13, 'JIMBO', 4, 8, 5, 74);
INSERT INTO gamestats VALUES ( 14, 'PRICELESS', 4, 4, 7, 79);
INSERT INTO penalties VALUES ( 29, 1500, 1);
INSERT INTO penalties VALUES ( 30, 500, 1);
INSERT INTO penalties VALUES ( 31, 2000, 14);
INSERT INTO penalties VALUES ( 32, 1500, 5);
INSERT INTO penalties VALUES ( 33, 1000, 6);
INSERT INTO penalties VALUES ( 34, 750, 7);
INSERT INTO penalties VALUES ( 35, 1200, 6);
INSERT INTO penalties VALUES ( 36, 2000, 7);
INSERT INTO penalties VALUES ( 37, 100, 1);
INSERT INTO penalties VALUES ( 38, 1900, 14);