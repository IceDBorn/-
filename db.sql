DROP TABLE IF EXISTS version;
CREATE TABLE IF NOT EXISTS version (
    version int
);
INSERT INTO version(version) VALUES (6);

DROP TABLE IF EXISTS genre CASCADE;
DROP TABLE IF EXISTS movie CASCADE;
DROP TABLE IF EXISTS rating CASCADE;
DROP TABLE IF EXISTS favorite CASCADE;
DROP TABLE IF EXISTS watchlist CASCADE;
DROP TABLE IF EXISTS history CASCADE;

CREATE TABLE IF NOT EXISTS account (
    id serial PRIMARY KEY,
    username text UNIQUE NOT NULL,
	password text NOT NULL,
	admin boolean NOT NULL,
	dark_theme boolean NOT NULL,
	picture text,
	created_at timestamp DEFAULT current_timestamp
);

CREATE TABLE IF NOT EXISTS genre (
    id serial PRIMARY KEY,
    name text UNIQUE NOT NULL
);

CREATE TABLE IF NOT EXISTS movie (
    id serial PRIMARY KEY,
    name text NOT NULL,
    description text NOT NULL,
    director text NOT NULL,
    writer text NOT NULL,
    stars text NOT NULL,
    picture text,
    genre_id int NOT NULL,
        CONSTRAINT fk_genre FOREIGN KEY(genre_id) REFERENCES genre(id)
            ON DELETE CASCADE ON UPDATE CASCADE,
    has_oscar boolean DEFAULT false,
    release_date date
);

CREATE TABLE IF NOT EXISTS rating (
    id serial PRIMARY KEY,
    value int NOT NULL,
    user_id int NOT NULL,
        CONSTRAINT fk_account FOREIGN KEY(user_id) REFERENCES account(id)
            ON DELETE CASCADE ON UPDATE CASCADE,
    movie_id int NOT NULL,
        CONSTRAINT fk_movie FOREIGN KEY(movie_id) REFERENCES movie(id)
            ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE IF NOT EXISTS favorite (
    id serial PRIMARY KEY,
    user_id int NOT NULL,
        CONSTRAINT fk_account FOREIGN KEY(user_id) REFERENCES account(id)
            ON DELETE CASCADE ON UPDATE CASCADE,
    movie_id int NOT NULL,
        CONSTRAINT fk_movie FOREIGN KEY(movie_id) REFERENCES movie(id)
            ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE IF NOT EXISTS watchlist (
    id serial PRIMARY KEY,
    user_id int NOT NULL,
        CONSTRAINT fk_account FOREIGN KEY(user_id) REFERENCES account(id)
            ON DELETE CASCADE ON UPDATE CASCADE,
    movie_id int NOT NULL,
        CONSTRAINT fk_movie FOREIGN KEY(movie_id) REFERENCES movie(id)
            ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE IF NOT EXISTS history (
    id serial PRIMARY KEY,
    user_id int NOT NULL,
        CONSTRAINT fk_account FOREIGN KEY(user_id) REFERENCES account(id)
            ON DELETE CASCADE ON UPDATE CASCADE,
    movie_id int NOT NULL,
        CONSTRAINT fk_movie FOREIGN KEY(movie_id) REFERENCES movie(id)
            ON DELETE CASCADE ON UPDATE CASCADE,
    created_at timestamp DEFAULT current_timestamp
);

INSERT INTO genre(name) VALUES ('Action');
INSERT INTO genre(name) VALUES ('Comedy');
INSERT INTO genre(name) VALUES ('Crime');
INSERT INTO genre(name) VALUES ('Documentary');
INSERT INTO genre(name) VALUES ('Drama');
INSERT INTO genre(name) VALUES ('Fantasy');
INSERT INTO genre(name) VALUES ('Horror');
INSERT INTO genre(name) VALUES ('Mystery');
INSERT INTO genre(name) VALUES ('Romance');
INSERT INTO genre(name) VALUES ('Sci-Fi');
INSERT INTO genre(name) VALUES ('Western');

INSERT INTO movie(name, description, director, writer, stars, picture, genre_id, has_oscar, release_date)
VALUES
(
	'The Fast and the Furious',
	'Los Angeles police officer Brian O''Conner must decide where his loyalty really lies when he becomes enamored with the street racing world he has been sent undercover to destroy.',
	'Rob Cohen',
	'Ken Li, Gary Scott Thompson',
	'Vin Diesel, Paul Walker, Michelle Rodriguez',
	'https://i.imgur.com/FhyeSsb.jpg',
	1,
	false,
	'2001-06-22'
),
(
	'2 Fast 2 Furious',
	'Former cop Brian O''Conner is called upon to bust a dangerous criminal and he recruits the help of a former childhood friend and street racer who has a chance to redeem himself.',
	'John Singleton',
	'Gary Scott Thompson, Michael Brandt',
	'Paul Walker, Tyrese Gibson, Cole Hauser',
	'https://i.imgur.com/Yv6lVEX.jpg',
	1,
	false,
	'2003-06-06'
),
(
	'The Fast and the Furious: Tokyo Drift',
	'A teenager becomes a major competitor in the world of drift racing after moving in with his father in Tokyo to avoid a jail sentence in America.',
	'Justin Lin',
	'Chris Morgan',
	'Lucas Black, Zachery Ty Bryan, Shad Moss',
	'https://i.imgur.com/uBXaXiz.jpg',
	1,
	false,
	'2006-06-16'
),
(
	'Fast & Furious',
	'Brian O''Conner, back working for the FBI in Los Angeles, teams up with Dominic Toretto to bring down a heroin importer by infiltrating his operation.',
	'Justin Lin',
	'Chris Morgan, Gary Scott Thompson',
	'Vin Diesel, Paul Walker, Michelle Rodriguez',
	'https://i.imgur.com/4ODJmnj.jpg',
	1,
	false,
	'2009-04-03'
),
(
	'Fast Five',
	'Dominic Toretto and his crew of street racers plan a massive heist to buy their freedom while in the sights of a powerful Brazilian drug lord and a dangerous federal agent.',
	'Justin Lin',
	'Chris Morgan, Gary Scott Thompson',
	'Vin Diesel, Paul Walker, Dwayne Johnson',
	'https://i.imgur.com/UvSue0t.jpg',
	1,
	false,
	'2011-04-29'
),
(
	'Fast & Furious 6',
	'Hobbs has Dominic and Brian reassemble their crew to take down a team of mercenaries: Dominic unexpectedly gets sidetracked with facing his presumed deceased girlfriend, Letty.',
	'Justin Lin',
	'Chris Morgan, Gary Scott Thompson',
	'Vin Diesel, Paul Walker, Dwayne Johnson',
	'https://i.imgur.com/6yrUuSB.jpg',
	1,
	false,
	'2013-05-24'
),
(
	'Furious 7',
	'Deckard Shaw seeks revenge against Dominic Toretto and his family for his comatose brother.',
	'James Wan',
	'Chris Morgan, Gary Scott Thompson',
	'Vin Diesel, Paul Walker, Dwayne Johnson',
	'https://i.imgur.com/X6jtWYl.jpg',
	1,
	false,
	'2015-04-03'
),
(
	'The Fate of the Furious',
	'When a mysterious woman seduces Dominic Toretto into the world of terrorism and a betrayal of those closest to him, the crew face trials that will test them as never before.',
	'F. Gary Gray',
	'Chris Morgan, Gary Scott Thompson',
	'Vin Diesel, Jason Statham, Dwayne Johnson',
	'https://i.imgur.com/zGbkgqX.jpg',
	1,
	false,
	'2017-04-14'
),
(
	'F9',
	'Cypher enlists the help of Jakob, Dom''s younger brother to take revenge on Dom and his team.',
	'Justin Lin',
	'Daniel Casey, Gary Scott Thompson',
	'Vin Diesel, Michelle Rodriguez, Amber Sienna',
	'https://i.imgur.com/YUxiOjo.jpg',
	1,
	false,
	'2021-06-25'
),
(
	'Gemini Man',
	'Henry Brogan is an elite, 51-year-old assassin who’s ready to call it quits after completing his 72nd job. But his plans get turned upside down when he becomes the target of a mysterious operative who can seemingly predict his every move. To his horror, Brogan soon learns that the man who’s trying to kill him is a younger, faster, cloned version of himself.',
	'Ang Lee',
	'Darren Lemke,David Benioff',
	'Will Smith, Mary Elizabeth Winstead, Clive Owen, Benedict Wong',
	'https://i.imgur.com/ZxisKoX.jpg',
	1,
	false,
	'2019-10-01'
),
(
	'The Equalizer',
	'A man who believes he has put his mysterious past behind him cannot stand idly by when he meets a young girl under the control of ultra-violent Russian gangsters.',
	'Antoine Fuqua',
	'Richard Wenk',
	'Denzel Washington, Marton Csokas, Chloë Grace Moretz, David Harbour, Bill Pullman, Melissa Leo',
	'https://i.imgur.com/DY2nggY.jpg',
	1,
	false,
	'2014-09-07'
),
(
	'Interstellar',
	'A team of explorers travel through a wormhole in space in an attempt to ensure humanitys survival.',
	'Christopher Nolan',
	'Jonathan Nolan, Christopher Nolan',
	'Matthew McConaughey, Anne Hathaway, Jessica Chastain',
	'https://i.imgur.com/QCkaZMx.jpg',
	1,
	false,
	'2014-11-06'
),
(
	'Tenet',
	'Armed with only one word, Tenet, and fighting for the survival of the entire world, a Protagonist journeys through a twilight world of international espionage on a mission that will unfold in something beyond real time.',
	'Christopher Nolan',
	'Christopher Nolan',
	'John David Washington, Robert Pattinson, Elizabeth Debicki',
	'https://i.imgur.com/BzHgiG3.jpg',
	1,
	true,
	'2020-08-26'
),
(
	'Shrek',
	'A mean lord exiles fairytale creatures to the swamp of a grumpy ogre, who must go on a quest and rescue a princess for the lord in order to get his land back.',
	'Andrew Adamson, Vicky Jenson',
	'William Steig',
	'Mike Myers, Eddie Murphy, Cameron Diaz',
	'https://i.imgur.com/b7zU4iv.jpg',
	2,
	true,
	'2001-05-18'
),
(
	'Shrek 2',
	'Shrek and Fiona travel to the Kingdom of Far Far Away, where Fiona''s parents are King and Queen, to celebrate their marriage. When they arrive, they find they are not as welcome as they thought they would be.',
	'Andrew Adamson, Kelly Asbury',
	'William Steig',
	'Mike Myers, Eddie Murphy, Cameron Diaz',
	'https://i.imgur.com/m09nqDO.jpg',
	2,
	false,
	'2004-05-19'
),
(
	'Shrek the Third',
	'Reluctantly designated as the heir to the land of Far, Far Away, Shrek hatches a plan to install the rebellious Artie as the new king while Princess Fiona tries to fend off a coup d''état by the jilted Prince Charming.',
	'Chris Miller, Raman Hui',
	'Jeffrey Price',
	'Mike Myers, Eddie Murphy, Cameron Diaz',
	'https://i.imgur.com/d8kI9ph.jpg',
	2,
	false,
	'2007-05-18'
),
(
	'Shrek Forever After',
	'Rumpelstiltskin tricks a mid-life crisis burdened Shrek into allowing himself to be erased from existence and cast in a dark alternate timeline where Rumpelstiltskin rules supreme.',
	'Mike Mitchell',
	'Josh Klausner, Darren Lemke',
	'Mike Myers, Eddie Murphy, Cameron Diaz',
	'https://i.imgur.com/Gg8l7q0.jpg',
	2,
	false,
	'2010-05-21'
),
(
	'Spy',
	'A desk-bound CIA analyst volunteers to go undercover to infiltrate the world of a deadly arms dealer, and prevent diabolical global disaster.',
	'Paul Feig',
	'Paul Feig',
	'Melissa McCarthy, Rose Byrne, Jude Law',
	'https://i.imgur.com/3LhK1re.jpg',
	2,
	false,
	'2015-06-18'
),
(
	'Murder Mystery',
	'A New York cop and his wife go on a European vacation to reinvigorate the spark in their marriage',
	'Kyle Newacheck',
	'James Vanderbilt',
	'Adam Sandler, Jennifer Aniston, Luke Evans',
	'https://i.imgur.com/7EkXL4t.jpg',
	2,
	false,
	'2019-06-14'
),
(
	'Once Upon a Time... in Hollywood',
	'A faded television actor and his stunt double strive to achieve fame and success in the final years of Hollywoods Golden Age in 1969 Los Angeles.',
	'Quentin Tarantino',
	'Quentin Tarantino',
	'Leonardo DiCaprio, Brad Pitt, Margot Robbie',
	'https://i.imgur.com/LxKLOnA.jpg',
	2,
	false,
	'2019-08-22'
),
(
	'Bad Boys',
	'Two hip detectives protect a witness to a murder while investigating a case of stolen heroin from the evidence storage room from their police precinct.',
	'Michael Bay',
	'George Gallo',
	'Will Smith, Martin Lawrence, Lisa Boyle',
	'https://i.imgur.com/AHoEi4B.jpg',
	2,
	false,
	'1995-09-01'
),
(
	'White Chicks',
	'Two disgraced FBI agents go way undercover in an effort to protect hotel heiresses the Wilson sisters from a kidnapping plot.',
	'Keenen Ivory Wayans',
	'Keenen Ivory Wayans',
	'Marlon Wayans, Shawn Wayans, Busy Philipps',
	'https://i.imgur.com/GjidYwH.jpg',
	2,
	false,
	'2004-06-23'
),
(
	'The Godfather',
	'An organized crime dynasty''s aging patriarch transfers control of his clandestine empire to his reluctant son.',
	'Francis Ford Coppola',
	'Mario Puzo, Francis Ford Coppola',
	'Marlon Brando, Al Pacino, James Caan',
	'https://i.imgur.com/ngQjWXf.jpg',
	3,
	true,
	'1972-03-24'
),
(
	'The Godfather: Part 2',
	'The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.',
	'Francis Ford Coppola',
	'Mario Puzo, Francis Ford Coppola',
	'Al Pacino, Robert De Niro, Robert Duvall',
	'https://i.imgur.com/ftjvAug.jpg',
	3,
	false,
	'1974-12-18'
),
(
	'The Godfather: Part 3',
	'Follows Michael Corleone, now in his 60s, as he seeks to free his family from crime and find a suitable successor to his empire.',
	'Francis Ford Coppola',
	'Mario Puzo, Francis Ford Coppola',
	'Al Pacino, Diane Keaton, Andy Garcia',
	'https://i.imgur.com/IG3iG1v.jpg',
	3,
	false,
	'1990-12-25'
),
(
	'John Wick',
	'An ex-hit-man comes out of retirement to track down the gangsters that killed his dog and took everything from him.',
	'Chad Stahelski, David Leitch',
	'Derek Kolstad',
	'Keanu Reeves, Michael Nyqvist, Alfie Allen',
	'https://i.imgur.com/ZeI3b8h.jpg',
	3,
	true,
	'2014-10-24'
),
(
	'John Wick: Chapter 2',
	'After returning to the criminal underworld to repay a debt, John Wick discovers that a large bounty has been put on his life.',
	'Chad Stahelski',
	'Derek Kolstad',
	'Keanu Reeves, Riccardo Scamarcio, Ian McShane',
	'https://i.imgur.com/tXZeBx8.jpg',
	3,
	false,
	'2017-02-10'
),
(
	'John Wick: Chapter 3 - Parabellum',
	'John Wick is on the run after killing a member of the international assassins'' guild, and with a $14 million price tag on his head, he is the target of hit men and women everywhere.',
	'Chad Stahelski',
	'Derek Kolstad, Shay Hatten',
	'Keanu Reeves, Halle Berry, Ian McShane',
	'https://i.imgur.com/F0ajOPH.jpg',
	3,
	false,
	'2019-05-17'
),
(
	'John Wick: Chapter 4',
	'The continuing adventures of assassin John Wick.',
	'Chad Stahelski',
	'Derek Kolstad, Shay Hatten',
	'Keanu Reeves',
	'https://i.imgur.com/tJlRxpF.jpg',
	3,
	false,
	'2022-05-27'
),
(
	'The Great Hack',
	'The Cambridge Analytica scandal is examined through the roles of several affected persons.',
	'Karim Amer, Jehane Noujaim',
	'Karim Amer, Erin Barnett',
	'Brittany Kaiser, David Carroll, Paul-Olivier Dehayes',
	'https://i.imgur.com/U9cRtmY.jpg',
	4,
	false,
	'2019-07-24'
),
(
	'Coded Bias',
	'When MIT Media Lab researcher Joy Buolamwini discovers that facial recognition does not see dark-skinned faces accurately, she embarks on a journey to push for the first-ever U.S. legislation against bias in algorithms that impact us all.',
	'Shalini Kantayya',
	'Shalini Kantayya, Christopher Seward',
	'Joy Buolamwini, Meredith Broussard, Cathy O''Neil',
	'https://i.imgur.com/eYMYWQg.jpg',
	4,
	false,
	'2020-11-11'
),
(
	'13th',
	'An in-depth look at the prison system in the United States and how it reveals the nation''s history of racial inequality.',
	'Ava DuVernay',
	'Spencer Averick, Ava DuVernay',
	'Melina Abdullah, Michelle Alexander, Cory Booker',
	'https://i.imgur.com/5cJTGhK.jpg',
	4,
	false,
	'2016-10-07'
),
(
	'The Social Dilemma',
	'Explores the dangerous human impact of social networking, with tech experts sounding the alarm on their own creations.',
	'Jeff Orlowski',
	'Davis Coombe, Vickie Curtis',
	'Tristan Harris, Jeff Seibert, Bailey Richardson',
	'https://i.imgur.com/WVcxfXQ.jpg',
	4,
	false,
	'2020-09-09'
),
(
	'Roma',
	'A year in the life of a middle-class family''s maid in Mexico City in the early 1970s.',
	'Alfonso Cuarón',
	'Alfonso Cuarón',
	'Yalitza Aparicio, Marina de Tavira, Diego Cortina Autrey',
	'https://i.imgur.com/GyHTr6a.jpg',
	5,
	true,
	'2018-11-21'
),
(
	'Bohemian Rhapsody',
	'The story of the legendary British rock band Queen and lead singer Freddie Mercury, leading up to their famous performance at Live Aid (1985).',
	'Bryan Singer',
	'Anthony McCarten, Peter Morgan',
	'Rami Malek, Lucy Boynton, Gwilym Lee',
	'https://i.imgur.com/wpax3Rj.jpg',
	5,
	true,
	'2018-11-02'
),
(
	'The Trial of the Chicago 7',
	'The story of 7 people on trial stemming from various charges surrounding the uprising at the 1968 Democratic National Convention in Chicago, Illinois.',
	'Aaron Sorkin',
	'Aaron Sorkin',
	'Eddie Redmayne, Alex Sharp, Sacha Baron Cohen',
	'https://i.imgur.com/PJtullz.jpg',
	5,
	true,
	'2020-10-01'
),
(
	'The Martian',
	'An astronaut becomes stranded on Mars after his team assume him dead, and must rely on his ingenuity to find a way to signal to Earth that he is alive.',
	'Ridley Scott',
	'Drew Goddard',
	'Matt Damon, Jessica Chastain, Kristen Wiig',
	'https://i.imgur.com/xZTvgiD.jpg',
	5,
	false,
	'2015-10-01'
),
(
	'Joker',
	'In Gotham City, mentally troubled comedian Arthur Fleck is disregarded and mistreated by society. He then embarks on a downward spiral of revolution and bloody crime. This path brings him face-to-face with his alter-ego: the Joker.',
	'Todd Phillips',
	'Todd Phillips, Scott Silver',
	'Joaquin Phoenix, Robert De Niro, Zazie Beetz',
	'https://i.imgur.com/WPZHGII.jpg',
	5,
	false,
	'2019-10-03'
),
(
	'Harry Potter and the Sorcerer''s Stone',
	'An orphaned boy enrolls in a school of wizardry, where he learns the truth about himself, his family and the terrible evil that haunts the magical world.',
	'Chris Columbus',
	'J.K. Rowling, Steve Kloves',
	'Daniel Radcliffe, Rupert Grint, Richard Harris',
	'https://i.imgur.com/SGuXDFZ.jpg',
	6,
	false,
	'2001-11-16'
),
(
	'Harry Potter and the Chamber of Secrets',
	'An ancient prophecy seems to be coming true when a mysterious presence begins stalking the corridors of a school of magic and leaving its victims paralyzed.',
	'Chris Columbus',
	'J.K. Rowling, Steve Kloves',
	'Daniel Radcliffe, Rupert Grint, Emma Watson',
	'https://i.imgur.com/xk1eis6.jpg',
	6,
	false,
	'2002-11-15'
),
(
	'Harry Potter and the Prisoner of Azkaban',
	'Harry Potter, Ron and Hermione return to Hogwarts School of Witchcraft and Wizardry for their third year of study, where they delve into the mystery surrounding an escaped prisoner who poses a dangerous threat to the young wizard.',
	'Alfonso Cuarón',
	'J.K. Rowling, Steve Kloves',
	'Daniel Radcliffe, Rupert Grint, Emma Watson',
	'https://i.imgur.com/h98VBUl.jpg',
	6,
	false,
	'2004-06-04'
),
(
	'Harry Potter and the Goblet of Fire',
	'Harry Potter finds himself competing in a hazardous tournament between rival schools of magic, but he is distracted by recurring nightmares.',
	'Mike Newell',
	'J.K. Rowling, Steve Kloves',
	'Daniel Radcliffe, Rupert Grint, Emma Watson',
	'https://i.imgur.com/uvYnZAy.jpg',
	6,
	false,
	'2005-11-18'
),
(
	'Harry Potter and the Order of the Phoenix',
	'With their warning about Lord Voldemort''s return scoffed at, Harry and Dumbledore are targeted by the Wizard authorities as an authoritarian bureaucrat slowly seizes power at Hogwarts.',
	'David Yates',
	'J.K. Rowling, Michael Goldenberg',
	'Daniel Radcliffe, Rupert Grint, Emma Watson',
	'https://i.imgur.com/c7CngNB.jpg',
	6,
	false,
	'2007-07-11'
),
(
	'Harry Potter and the Half-Blood Prince',
	'As Harry Potter begins his sixth year at Hogwarts, he discovers an old book marked as "the property of the Half-Blood Prince" and begins to learn more about Lord Voldemort''s dark past.',
	'David Yates',
	'J.K. Rowling, Steve Kloves',
	'Daniel Radcliffe, Rupert Grint, Emma Watson',
	'https://i.imgur.com/As6h5Cs.jpg',
	6,
	false,
	'2009-07-15'
),
(
	'Harry Potter and the Deathly Hallows: Part 1',
	'As Harry, Ron, and Hermione race against time and evil to destroy the Horcruxes, they uncover the existence of the three most powerful objects in the wizarding world: the Deathly Hallows.',
	'David Yates',
	'J.K. Rowling, Steve Kloves',
	'Daniel Radcliffe, Rupert Grint, Emma Watson',
	'https://i.imgur.com/D14dT0D.jpg',
	6,
	false,
	'2010-11-19'
),
(
	'Harry Potter and the Deathly Hallows: Part 2',
	'Harry, Ron, and Hermione search for Voldemort''s remaining Horcruxes in their effort to destroy the Dark Lord as the final battle rages on at Hogwarts.',
	'David Yates',
	'J.K. Rowling, Steve Kloves',
	'Daniel Radcliffe, Rupert Grint, Emma Watson',
	'https://i.imgur.com/TbihoRC.jpg',
	6,
	false,
	'2011-07-15'
),
(
	'The Green Mile',
	'The lives of guards on Death Row are affected by one of their charges: a black man accused of child murder and rape, yet who has a mysterious gift.',
	'Frank Darabont',
	'Stephen King',
	'Tom Hanks, Michael Clarke Duncan, David Morse',
	'https://i.imgur.com/9jckIz7.jpg',
	6,
	false,
	'2000-02-11'
),
(
	'Mulan',
	'A young Chinese maiden disguises herself as a male warrior in order to save her father.',
	'Niki Caro',
	'Rick Jaffa',
	'Yifei Liu, Donnie Yen, Gong Li',
	'https://i.imgur.com/aLT61Ci.jpg',
	6,
	true,
	'2020-09-10'
),
(
	'Aquaman',
	'Arthur Curry, the human-born heir to the underwater kingdom of Atlantis, goes on a quest to prevent a war between the worlds of ocean and land.',
	'James Wan',
	'David Leslie Johnson-McGoldrick, Will Beall ',
	'Jason Momoa, Amber Heard, Willem Dafoe',
	'https://i.imgur.com/Y7vJYhg.jpg',
	6,
	false,
	'2018-12-13'
),
(
	'The Midnight Sky',
	'This post-apocalyptic tale follows Augustine, a lonely scientist in the Arctic, as he races to stop Sully and her fellow astronauts from returning home to a mysterious global catastrophe.',
	'George Clooney',
	'Lily Brooks-Dalton, Mark L. Smith',
	'George Clooney, Felicity Jones, David Oyelowo',
	'https://i.imgur.com/RVvbfVP.jpg',
	6,
	true,
	'2020-12-23'
),
(
	'Tomb Raider',
	'Lara Croft (Alicia Vikander), the fiercely independent daughter of a missing adventurer, must push herself beyond her limits when she discovers the island where her father, Lord Richard Croft (Dominic West) disappeared.',
	'Roar Uthaug',
	'Geneva Robertson-Dworet, Alastair Siddons',
	'Alicia Vikander, Dominic West, Walton Goggins',
	'https://i.imgur.com/HXfNLe2.jpg',
	6,
	false,
	'2018-03-15'
),
(
	'Insidious',
	'A family looks to prevent evil spirits from trapping their comatose child in a realm called The Further.',
	'James Wan',
	'Leigh Whannell',
	'Patrick Wilson, Rose Byrne, Ty Simpkins',
	'https://i.imgur.com/tJiir3K.jpg',
	7,
	false,
	'2011-04-01'
),
(
	'Insidious: Chapter 2',
	'The Lamberts believe that they have defeated the spirits that have haunted their family, but they soon discover that evil is not beaten so easily.',
	'James Wan',
	'Leigh Whannell, James Wan',
	'Patrick Wilson, Rose Byrne, Barbara Hershey',
	'https://i.imgur.com/9wr5ix5.jpg',
	7,
	false,
	'2013-09-13'
),
(
	'Insidious: Chapter 3',
	'A prequel set before the haunting of the Lambert family that reveals how gifted psychic Elise Rainier reluctantly agrees to use her ability to contact the dead in order to help a teenage girl who has been targeted by a dangerous supernatural entity.',
	'Leigh Whannell',
	'Leigh Whannell',
	'Dermot Mulroney, Stefanie Scott, Angus Sampson',
	'https://i.imgur.com/d70fjdF.jpg',
	7,
	false,
	'2015-06-05'
),
(
	'Insidious: The Last Key',
	'Parapsychologist Dr. Elise Rainier faces her most fearsome and personal haunting yet, as she is drawn back to her ghostly childhood home, where the terror began.',
	'Adam Robitel',
	'Leigh Whannell',
	'Lin Shaye, Leigh Whannell, Angus Sampson',
	'https://i.imgur.com/UYk2bKh.jpg',
	7,
	false,
	'2018-01-05'
),
(
	'Shutter Island',
	'In 1954, a U.S. Marshal investigates the disappearance of a murderer who escaped from a hospital for the criminally insane.',
	'Martin Scorsese',
	'Laeta Kalogridis, Dennis Lehane',
	'Leonardo DiCaprio, Emily Mortimer, Mark Ruffalo',
	'https://i.imgur.com/TTktt3M.jpg',
	7,
	false,
	'2010-02-19'
),
(
	'Get Out',
	'A young African-American visits his white girlfriends parents for the weekend, where his simmering uneasiness about their reception of him eventually reaches a boiling point.',
	'Jordan Peele',
	'Jordan Peele',
	'Daniel Kaluuya, Allison Williams, Bradley Whitford',
	'https://i.imgur.com/6AlWYA5.jpg',
	7,
	false,
	'2017-03-16'
),
(
	'Wrong Turn',
	'Friends hiking the Appalachian Trail are confronted by The Foundation, a community of people who have lived in the mountains for hundreds of years.',
	'Mike P. Nelson',
	'Alan B. McElroy',
	'Charlotte Vega, Adain Bradley, Bill Sage',
	'https://i.imgur.com/qRrt3XD.jpg',
	7,
	false,
	'2021-01-26'
),
(
	'The Shining',
	'A family heads to an isolated hotel for the winter where a sinister presence influences the father into violence, while his psychic son sees horrific forebodings from both past and future.',
	'Stanley Kubrick',
	'Stephen King',
	'Jack Nicholson, Shelley Duvall, Danny Lloyd',
	'https://i.imgur.com/1cLjlnF.jpg',
	7,
	false,
	'1980-12-22'
),
(
	'Bird Box',
	'Five years after an ominous unseen presence drives most of society to suicide, a mother and her two children make a desperate bid to reach safety.',
	'Susanne Bier',
	'Eric Heisserer, Josh Malerman',
	'Sandra Bullock, Trevante Rhodes, John Malkovich',
	'https://i.imgur.com/8G2p1U8.jpg',
	7,
	false,
	'2018-12-21'
),
(
	'Paranormal Activity',
	'After moving into a suburban home, a couple becomes increasingly disturbed by a nightly demonic presence.',
	'Oren Peli',
	'Oren Peli',
	'Katie Featherston, Micah Sloat, Mark Fredrichs',
	'https://i.imgur.com/uqBObxY.jpg',
	8,
	false,
	'2009-10-16'
),
(
	'Paranormal Activity 2',
	'After experiencing what they think are a series of "break-ins", a family sets up security cameras around their home, only to realize that the events unfolding before them are more sinister than they seem.',
	'Tod Williams',
	'Michael R. Perry, Christopher Landon',
	'Katie Featherston, Micah Sloat, Molly Ephraim',
	'https://i.imgur.com/cXrxxCj.jpg',
	8,
	false,
	'2010-10-22'
),
(
	'Paranormal Activity 3',
	'In 1988, young sisters Katie and Kristi befriend an invisible entity who resides in their home.',
	'Henry Joost, Ariel Schulman',
	'Christopher Landon, Oren Peli',
	'Chloe Csengery, Jessica Tyler Brown, Christopher Nicholas Smith',
	'https://i.imgur.com/D5zL502.jpg',
	8,
	false,
	'2011-10-21'
),
(
	'Paranormal Activity 4',
	'It has been five years since the disappearance of Katie and Hunter, and a suburban family witness strange events in their neighborhood when a woman and a mysterious child move in.',
	'Henry Joost, Ariel Schulman',
	'Christopher Landon, Chad Feehan',
	'Stephen Dunham, Katie Featherston, Matt Shively',
	'https://i.imgur.com/wge84iw.jpg',
	8,
	false,
	'2012-10-19'
),
(
	'Paranormal Activity: The Marked Ones',
	'When a young man becomes the target of a malevolent entity, he must uncover its true intentions before it takes complete control of him.',
	'Christopher Landon',
	'Christopher Landon, Oren Peli',
	'Andrew Jacobs, Jorge Diaz, Gabrielle Walsh',
	'https://i.imgur.com/YsRcd0I.jpg',
	8,
	false,
	'2014-01-03'
),
(
	'Paranormal Activity: The Ghost Dimension',
	'Using a special camera that can see spirits, a family must protect their daughter from an evil entity with a sinister plan.',
	'Gregory Plotkin',
	'Jason Pagan, Andrew Deutschman',
	'Chris J. Murray, Brit Shaw, Ivy George',
	'https://i.imgur.com/Crm7OSx.jpg',
	8,
	false,
	'2015-10-23'
),
(
	'Paranormal Activity 7',
	'Moving in together before college starts, four friends discover a gruesome past of their house and the connection to the 1988 incidents.',
	'-',
	'Oren Peli',
	'-',
	'https://i.imgur.com/CkVyZdr.jpg',
	8,
	false,
	'2022-03-04'
),
	'The Gift',
	'A married couple, Simon and Robyn, run into Gordo, an old acquaintance. Things take a turn when Gordo begins to drop in unannounced at their house and inundates them with mysterious gifts.',
	'Joel Edgerton',
	'Joel Edgerton',
	'Jason Bateman, Rebecca Hall, Joel Edgerton',
	'https://i.imgur.com/2zeqmvD.jpg',
	8,
	false,
	'2015-08-07'
),
(
	'The Prestige',
	'After a tragic accident, two stage magicians engage in a battle to create the ultimate illusion while sacrificing everything they have to outwit each other.',
	'Christopher Nolan',
	'Jonathan Nolan, Christopher Nolan',
	'Christian Bale, Hugh Jackman, Scarlett Johansson',
	'https://i.imgur.com/kIQuU4f.jpg',
	8,
	false,
	'2006-12-26'
),
(
	'Seven',
	'Two detectives, a rookie and a veteran, hunt a serial killer who uses the seven deadly sins as his motives.',
	'David Fincher',
	'Andrew Kevin Walker',
	'Morgan Freeman, Brad Pitt, Kevin Spacey',
	'https://i.imgur.com/1GCmqfG.jpg',
	8,
	false,
	'1996-02-09'
),
(
	'Dark Places',
	'Libby Day was only eight years old when her family was brutally murdered in their rural Kansas farmhouse. Almost thirty years later, she reluctantly agrees to revisit the crime and uncovers the wrenching truths that led up to that tragic night.',
	'Gilles Paquet-Brenner',
	'Quentin Tarantino',
	'Gilles Paquet-Brenner',
	'https://i.imgur.com/vNBcRK7.jpg',
	8,
	false,
	'2015-07-09'
),
(
	'Memento',
	'A man with short-term memory loss attempts to track down his wifes murderer.',
	'Christopher Landon',
	'Jonathan Nolan, Christopher Nolan',
	'Guy Pearce, Carrie-Anne Moss, Joe Pantoliano',
	'https://i.imgur.com/yOCngLh.jpg',
	8,
	false,
	'2001-04-26'
),
(
	'The Notebook',
	'A poor yet passionate young man falls in love with a rich young woman, giving her a sense of freedom, but they are soon separated because of their social differences.',
	'Nick Cassavetes',
	'Jeremy Leven, Jan Sardi',
	'Gena Rowlands, James Garner, Rachel McAdams',
	'https://i.imgur.com/2ufOYWD.jpg',
	9,
	false,
	'2004-06-25'
),
(
	'Titanic',
	'A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.',
	'James Cameron',
	'James Cameron',
	'Leonardo DiCaprio, Kate Winslet, Billy Zane',
	'https://i.imgur.com/vci8Zwh.jpg',
	9,
	false,
	'1997-12-19'
),
(
	'Dear John',
	'A romantic drama about a soldier who falls for a conservative college student while he''s home on leave.',
	'JLasse Hallström',
	'Jamie Linden, Nicholas Sparks',
	'Channing Tatum, Amanda Seyfried, Richard Jenkins',
	'https://i.imgur.com/b5ZhOc4.jpg',
	9,
	false,
	'2010-02-05'
),
(
	'The Longest Ride',
	'The lives of a young couple intertwine with a much older man, as he reflects back on a past love.',
	'George Tillman Jr.',
	'Nicholas Sparks, Craig Bolotin',
	'Scott Eastwood, Britt Robertson, Alan Alda',
	'https://i.imgur.com/VPaQOQM.jpg',
	9,
	false,
	'2015-04-10'
),
(
	'Star Wars: Episode IV - A New Hope',
	'Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, a Wookiee and two droids to save the galaxy from the Empire''s world-destroying battle station, while also attempting to rescue Princess Leia from the mysterious Darth Vader.',
	'George Lucas',
	'George Lucas',
	'Mark Hamill, Harrison Ford, Carrie Fisher',
	'https://i.imgur.com/9q6q5j8.jpg',
	10,
	true,
	'1977-05-25'
),
(
	'Star Wars: Episode V - The Empire Strikes Back',
	'After the Rebels are brutally overpowered by the Empire on the ice planet Hoth, Luke Skywalker begins Jedi training with Yoda, while his friends are pursued by Darth Vader and a bounty hunter named Boba Fett all over the galaxy.',
	'Irvin Kershner',
	'Leigh Brackett, Lawrence Kasdan',
	'Mark Hamill, Harrison Ford, Carrie Fisher',
	'https://i.imgur.com/9HqjKBw.jpg',
	10,
	false,
	'1980-06-20'
),
(
	'Star Wars: Episode VI - Return of the Jedi',
	'After a daring mission to rescue Han Solo from Jabba the Hutt, the Rebels dispatch to Endor to destroy the second Death Star. Meanwhile, Luke struggles to help Darth Vader back from the dark side without falling into the Emperor''s trap.',
	'Richard Marquand',
	'Lawrence Kasdan, George Lucas',
	'Mark Hamill, Harrison Ford, Carrie Fisher',
	'https://i.imgur.com/14bbPkR.jpg',
	10,
	false,
	'1983-05-25'
),
(
	'Star Wars: Episode I - The Phantom Menace',
	'Two Jedi escape a hostile blockade to find allies and come across a young boy who may bring balance to the Force, but the long dormant Sith resurface to claim their original glory.',
	'George Lucas',
	'George Lucas',
	'Ewan McGregor, Liam Neeson, Natalie Portman',
	'https://i.imgur.com/SIVomdY.jpg',
	10,
	false,
	'1999-05-19'
),
(
	'Star Wars: Episode II - Attack of the Clones',
	'Ten years after initially meeting, Anakin Skywalker shares a forbidden romance with Padmé Amidala, while Obi-Wan Kenobi investigates an assassination attempt on the senator and discovers a secret clone army crafted for the Jedi.',
	'George Lucas',
	'George Lucas, Jonathan Hales',
	'Hayden Christensen, Natalie Portman, Ewan McGregor',
	'https://i.imgur.com/U1jbsN1.jpg',
	10,
	false,
	'2002-05-16'
),
(
	'Star Wars: Episode III - Revenge of the Sith',
	'Three years into the Clone Wars, the Jedi rescue Palpatine from Count Dooku. As Obi-Wan pursues a new threat, Anakin acts as a double agent between the Jedi Council and Palpatine and is lured into a sinister plan to rule the galaxy.',
	'George Lucas',
	'George Lucas',
	'Hayden Christensen, Natalie Portman, Ewan McGregor',
	'https://i.imgur.com/wD8XaLh.jpg',
	10,
	false,
	'2005-05-19'
),
(
	'Star Wars: Episode VII - The Force Awakens',
	'As a new threat to the galaxy rises, Rey, a desert scavenger, and Finn, an ex-stormtrooper, must join Han Solo and Chewbacca to search for the one hope of restoring peace.',
	'J.J. Abrams',
	'Lawrence Kasdan, J.J. Abrams',
	'Daisy Ridley, John Boyega, Oscar Isaac',
	'https://i.imgur.com/jHqTgi1.jpg',
	10,
	false,
	'2015-12-18'
),
(
	'Star Wars: Episode VIII - The Last Jedi',
	'Rey develops her newly discovered abilities with the guidance of Luke Skywalker, who is unsettled by the strength of her powers. Meanwhile, the Resistance prepares for battle with the First Order.',
	'Rian Johnson',
	'Rian Johnson, George Lucas',
	'Daisy Ridley, John Boyega, Mark Hamill',
	'https://i.imgur.com/hxDNPnX.jpg',
	10,
	false,
	'2017-12-15'
),
(
	'Star Wars: Episode IX - The Rise of Skywalker',
	'The surviving members of the resistance face the First Order once again, and the legendary conflict between the Jedi and the Sith reaches its peak bringing the Skywalker saga to its end.',
	'J.J. Abrams',
	'Chris Terrio, J.J. Abrams',
	'Daisy Ridley, John Boyega, Oscar Isaac',
	'https://i.imgur.com/6fFmlMo.jpg',
	10,
	false,
	'2019-12-20'
),
(
	'Inception',
	'A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.',
	'Christopher Nolan',
	'Christopher Nolan',
	'Leonardo DiCaprio, Joseph Gordon-Levitt, Elliot Page',
	'https://i.imgur.com/Yun5EMP.jpg',
	10,
	false,
	'2010-08-24'
),
(
	'Blade Runner 2049',
	'Young Blade Runner Ks discovery of a long-buried secret leads him to track down former Blade Runner Rick Deckard, whos been missing for thirty years.',
	'Denis Villeneuve',
	'Hampton Fancher, Michael Green',
	'Harrison Ford, Ryan Gosling, Ana de Armas',
	'https://i.imgur.com/Rr3JLJY.jpg',
	10,
	false,
	'2017-10-05'
),
(
	'Mad Max: Fury Road',
	'In a post-apocalyptic wasteland, a woman rebels against a tyrannical ruler in search for her homeland with the aid of a group of female prisoners, a psychotic worshiper, and a drifter named Max.',
	'George Miller',
	'George Miller, Brendan McCarthy',
	'Tom Hardy, Charlize Theron, Nicholas Hoult',
	'https://i.imgur.com/tzMYMAO.jpg',
	10,
	false,
	'2015-05-14'
),
(
	'The Platform',
	'A vertical prison with one cell per level. Two people per cell. Only one food platform and two minutes per day to feed. An endless nightmare trapped in The Hole.',
	'Galder Gaztelu-Urrutia',
	'David Desola, Pedro Rivero',
	'Ivan Massagué, Zorion Eguileor, Antonia San Juan',
	'https://i.imgur.com/Xcuo7dN.jpg',
	10,
	false,
	'2019-11-08'
),
(
	'V for Vendetta',
	'In a future British tyranny, a shadowy freedom fighter, known only by the alias of "V", plots to overthrow it with the help of a young woman.',
	'James McTeigue',
	'Lilly Wachowski',
	'Hugo Weaving, Natalie Portman, Rupert Graves',
	'https://i.imgur.com/jU7kRfu.jpg',
	10,
	false,
	'2006-03-30'
),
(
	'Django Unchained',
	'With the help of a German bounty-hunter, a freed slave sets out to rescue his wife from a brutal plantation-owner in Mississippi.',
	'Quentin Tarantino',
	'Quentin Tarantino',
	'Jamie Foxx, Christoph Waltz, Leonardo DiCaprio',
	'https://i.imgur.com/o1qyrvP.jpg',
	11,
	true,
	'2012-12-25'
),
(
	'News of the World',
	'A Civil War veteran agrees to deliver a girl, taken by the Kiowa people years ago, to her aunt and uncle, against her will. They travel hundreds of miles and face grave dangers as they search for a place that either can call home.',
	'Paul Greengrass',
	'Paul Greengrass, Luke Davies',
	'Tom Hanks, Helena Zengel, Tom Astor',
	'https://i.imgur.com/nd12wjH.jpg',
	11,
	false,
	'2020-12-25'
),
(
	'Tombstone',
	'A successful lawman''s plans to retire anonymously in Tombstone, Arizona are disrupted by the kind of outlaws he was famous for eliminating.',
	'George P. Cosmatos, Kevin Jarre',
	'Kevin Jarre',
	'Kurt Russell, Val Kilmer, Sam Elliott',
	'https://i.imgur.com/TNkSP49.jpg',
	11,
	false,
	'1993-12-25'
),
(
	'The Magnificent Seven',
	'Seven gunmen from a variety of backgrounds are brought together by a vengeful young widow to protect her town from the private army of a destructive industrialist.',
	'Antoine Fuqua',
	'Akira Kurosawa, Shinobu Hashimoto',
	'Denzel Washington, Chris Pratt, Ethan Hawke',
	'https://i.imgur.com/jckODD4.jpg',
	11,
	false,
	'2016-09-23'
),
(
	'The Hateful Eight',
	'In the dead of a Wyoming winter, a bounty hunter and his prisoner find shelter in a cabin currently inhabited by a collection of nefarious characters.',
	'Quentin Tarantino',
	'Quentin Tarantino',
	'Samuel L. Jackson, Kurt Russell, Jennifer Jason Leigh',
	'https://i.imgur.com/l7pUURs.jpg',
	11,
	false,
	'2015-12-30'
);
