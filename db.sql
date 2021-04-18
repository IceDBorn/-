-- Version 2

DROP TABLE IF EXISTS genre CASCADE;
DROP TABLE IF EXISTS movie CASCADE;
DROP TABLE IF EXISTS rating CASCADE;
DROP TABLE IF EXISTS comment CASCADE;
DROP TABLE IF EXISTS favorite CASCADE;
DROP TABLE IF EXISTS watchlist CASCADE;
DROP TABLE IF EXISTS history CASCADE;

CREATE TABLE IF NOT EXISTS account (
    id serial PRIMARY KEY,
    name text,
    email text UNIQUE NOT NULL,
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
    release_date date
);

INSERT INTO movie(name, description, director, writer, stars, picture, genre_id, release_date)
VALUES 
(
	'The Fast and the Furious',
	'Los Angeles police officer Brian O''Conner must decide where his loyalty really lies when he becomes enamored with the street racing world he has been sent undercover to destroy.',
	'Rob Cohen',
	'Ken Li, Gary Scott Thompson',
	'Vin Diesel, Paul Walker, Michelle Rodriguez',
	'fast-and-furious-1.png',
	1,
	'2001-06-22'
),
(
	'2 Fast 2 Furious',
	'Former cop Brian O''Conner is called upon to bust a dangerous criminal and he recruits the help of a former childhood friend and street racer who has a chance to redeem himself.',
	'John Singleton',
	'Gary Scott Thompson, Michael Brandt',
	'Paul Walker, Tyrese Gibson, Cole Hauser',
	'fast-and-furious-2.png',
	1,
	'2003-06-06'
),
(
	'The Fast and the Furious: Tokyo Drift',
	'A teenager becomes a major competitor in the world of drift racing after moving in with his father in Tokyo to avoid a jail sentence in America.',
	'Justin Lin',
	'Chris Morgan',
	'Lucas Black, Zachery Ty Bryan, Shad Moss',
	'fast-and-furious-3.png',
	1,
	'2006-06-16'
),
(
	'Fast & Furious',
	'Brian O''Conner, back working for the FBI in Los Angeles, teams up with Dominic Toretto to bring down a heroin importer by infiltrating his operation.',
	'Justin Lin',
	'Chris Morgan, Gary Scott Thompson',
	'Vin Diesel, Paul Walker, Michelle Rodriguez',
	'fast-and-furious-4.png',
	1,
	'2009-04-03'
),
(
	'Fast Five',
	'Dominic Toretto and his crew of street racers plan a massive heist to buy their freedom while in the sights of a powerful Brazilian drug lord and a dangerous federal agent.',
	'Justin Lin',
	'Chris Morgan, Gary Scott Thompson',
	'Vin Diesel, Paul Walker, Dwayne Johnson',
	'fast-and-furious-5.png',
	1,
	'2011-04-29'
),
(
	'Fast & Furious 6',
	'Hobbs has Dominic and Brian reassemble their crew to take down a team of mercenaries: Dominic unexpectedly gets sidetracked with facing his presumed deceased girlfriend, Letty.',
	'Justin Lin',
	'Chris Morgan, Gary Scott Thompson',
	'Vin Diesel, Paul Walker, Dwayne Johnson',
	'fast-and-furious-6.png',
	1,
	'2013-05-24'
),
(
	'Furious 7',
	'Deckard Shaw seeks revenge against Dominic Toretto and his family for his comatose brother.',
	'James Wan',
	'Chris Morgan, Gary Scott Thompson',
	'Vin Diesel, Paul Walker, Dwayne Johnson',
	'fast-and-furious-7.png',
	1,
	'2015-04-03'
),
(
	'The Fate of the Furious',
	'When a mysterious woman seduces Dominic Toretto into the world of terrorism and a betrayal of those closest to him, the crew face trials that will test them as never before.',
	'F. Gary Gray',
	'Chris Morgan, Gary Scott Thompson',
	'Vin Diesel, Jason Statham, Dwayne Johnson',
	'fast-and-furious-8.png',
	1,
	'2017-04-14'
),
(
	'F9',
	'Cypher enlists the help of Jakob, Dom''s younger brother to take revenge on Dom and his team.',
	'Justin Lin',
	'Daniel Casey, Gary Scott Thompson',
	'Vin Diesel, Michelle Rodriguez, Amber Sienna',
	'fast-and-furious-9.png',
	1,
	'2021-06-25'
),
(
	'Shrek',
	'A mean lord exiles fairytale creatures to the swamp of a grumpy ogre, who must go on a quest and rescue a princess for the lord in order to get his land back.',
	'Andrew Adamson, Vicky Jenson',
	'William Steig',
	'Mike Myers, Eddie Murphy, Cameron Diaz',
	'shrek-1.png',
	2,
	'2001-05-18'
),
(
	'Shrek 2',
	'Shrek and Fiona travel to the Kingdom of Far Far Away, where Fiona''s parents are King and Queen, to celebrate their marriage. When they arrive, they find they are not as welcome as they thought they would be.',
	'Andrew Adamson, Kelly Asbury',
	'William Steig',
	'Mike Myers, Eddie Murphy, Cameron Diaz',
	'shrek-2.png',
	2,
	'2004-05-19'
),
(
	'Shrek the Third',
	'Reluctantly designated as the heir to the land of Far, Far Away, Shrek hatches a plan to install the rebellious Artie as the new king while Princess Fiona tries to fend off a coup d''état by the jilted Prince Charming.',
	'Chris Miller, Raman Hui',
	'Jeffrey Price',
	'Mike Myers, Eddie Murphy, Cameron Diaz',
	'shrek-3.png',
	2,
	'2007-05-18'
),
(
	'Shrek Forever After',
	'Rumpelstiltskin tricks a mid-life crisis burdened Shrek into allowing himself to be erased from existence and cast in a dark alternate timeline where Rumpelstiltskin rules supreme.',
	'Mike Mitchell',
	'Josh Klausner, Darren Lemke',
	'Mike Myers, Eddie Murphy, Cameron Diaz',
	'shrek-4.png',
	2,
	'2010-05-21'
),
(
	'The Godfather',
	'An organized crime dynasty''s aging patriarch transfers control of his clandestine empire to his reluctant son.',
	'Francis Ford Coppola',
	'Mario Puzo, Francis Ford Coppola',
	'Marlon Brando, Al Pacino, James Caan',
	'godfather-1.png',
	3,
	'1972-03-24'
),
(
	'The Godfather: Part 2',
	'The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.',
	'Francis Ford Coppola',
	'Mario Puzo, Francis Ford Coppola',
	'Al Pacino, Robert De Niro, Robert Duvall',
	'godfather-2.png',
	3,
	'1974-12-18'
),
(
	'The Godfather: Part 3',
	'Follows Michael Corleone, now in his 60s, as he seeks to free his family from crime and find a suitable successor to his empire.',
	'Francis Ford Coppola',
	'Mario Puzo, Francis Ford Coppola',
	'Al Pacino, Diane Keaton, Andy Garcia',
	'godfather-3.png',
	3,
	'1990-12-25'
),
(
	'John Wick',
	'An ex-hit-man comes out of retirement to track down the gangsters that killed his dog and took everything from him.',
	'Chad Stahelski, David Leitch',
	'Derek Kolstad',
	'Keanu Reeves, Michael Nyqvist, Alfie Allen',
	'john-wick-1.png',
	3,
	'2014-10-24'
),
(
	'John Wick: Chapter 2',
	'After returning to the criminal underworld to repay a debt, John Wick discovers that a large bounty has been put on his life.',
	'Chad Stahelski',
	'Derek Kolstad',
	'Keanu Reeves, Riccardo Scamarcio, Ian McShane',
	'john-wick-2.png',
	3,
	'2017-02-10'
),
(
	'John Wick: Chapter 3 - Parabellum',
	'John Wick is on the run after killing a member of the international assassins'' guild, and with a $14 million price tag on his head, he is the target of hit men and women everywhere.',
	'Chad Stahelski',
	'Derek Kolstad, Shay Hatten',
	'Keanu Reeves, Halle Berry, Ian McShane',
	'john-wick-3.png',
	3,
	'2019-05-17'
),
(
	'John Wick: Chapter 4',
	'The continuing adventures of assassin John Wick.',
	'Chad Stahelski',
	'Derek Kolstad, Shay Hatten',
	'Keanu Reeves',
	'john-wick-4.png',
	3,
	'2022-05-27'
),
(
	'The Great Hack',
	'The Cambridge Analytica scandal is examined through the roles of several affected persons.',
	'Karim Amer, Jehane Noujaim',
	'Karim Amer, Erin Barnett',
	'Brittany Kaiser, David Carroll, Paul-Olivier Dehayes',
	'the-great-hack.png',
	4,
	'2019-07-24'
),
(
	'Coded Bias',
	'When MIT Media Lab researcher Joy Buolamwini discovers that facial recognition does not see dark-skinned faces accurately, she embarks on a journey to push for the first-ever U.S. legislation against bias in algorithms that impact us all.',
	'Shalini Kantayya',
	'Shalini Kantayya, Christopher Seward',
	'Joy Buolamwini, Meredith Broussard, Cathy O''Neil',
	'coded-bias.png',
	4,
	'2020-11-11'
),
(
	'13th',
	'An in-depth look at the prison system in the United States and how it reveals the nation''s history of racial inequality.',
	'Ava DuVernay',
	'Spencer Averick, Ava DuVernay',
	'Melina Abdullah, Michelle Alexander, Cory Booker',
	'coded-bias.png',
	4,
	'2016-10-07'
),
(
	'The Social Dilemma',
	'Explores the dangerous human impact of social networking, with tech experts sounding the alarm on their own creations.',
	'Jeff Orlowski',
	'Davis Coombe, Vickie Curtis',
	'Tristan Harris, Jeff Seibert, Bailey Richardson',
	'the-social-dilemma.png',
	4,
	'2020-09-09'
),
(
	'Roma',
	'A year in the life of a middle-class family''s maid in Mexico City in the early 1970s.',
	'Alfonso Cuarón',
	'Alfonso Cuarón',
	'Yalitza Aparicio, Marina de Tavira, Diego Cortina Autrey',
	'roma.png',
	5,
	'2018-11-21'
),
(
	'Bohemian Rhapsody',
	'The story of the legendary British rock band Queen and lead singer Freddie Mercury, leading up to their famous performance at Live Aid (1985).',
	'Bryan Singer',
	'Anthony McCarten, Peter Morgan',
	'Rami Malek, Lucy Boynton, Gwilym Lee',
	'bohemian-rhapsody.png',
	5,
	'2018-11-02'
),
(
	'Harry Potter and the Sorcerer''s Stone',
	'An orphaned boy enrolls in a school of wizardry, where he learns the truth about himself, his family and the terrible evil that haunts the magical world.',
	'Chris Columbus',
	'J.K. Rowling, Steve Kloves',
	'Daniel Radcliffe, Rupert Grint, Richard Harris',
	'harry-potter-1.png',
	6,
	'2001-11-16'
),
(
	'Harry Potter and the Chamber of Secrets',
	'An ancient prophecy seems to be coming true when a mysterious presence begins stalking the corridors of a school of magic and leaving its victims paralyzed.',
	'Chris Columbus',
	'J.K. Rowling, Steve Kloves',
	'Daniel Radcliffe, Rupert Grint, Emma Watson',
	'harry-potter-2.png',
	6,
	'2002-11-15'
),
(
	'Harry Potter and the Prisoner of Azkaban',
	'Harry Potter, Ron and Hermione return to Hogwarts School of Witchcraft and Wizardry for their third year of study, where they delve into the mystery surrounding an escaped prisoner who poses a dangerous threat to the young wizard.',
	'Alfonso Cuarón',
	'J.K. Rowling, Steve Kloves',
	'Daniel Radcliffe, Rupert Grint, Emma Watson',
	'harry-potter-3.png',
	6,
	'2004-06-04'
),
(
	'Harry Potter and the Goblet of Fire',
	'Harry Potter finds himself competing in a hazardous tournament between rival schools of magic, but he is distracted by recurring nightmares.',
	'Mike Newell',
	'J.K. Rowling, Steve Kloves',
	'Daniel Radcliffe, Rupert Grint, Emma Watson',
	'harry-potter-4.png',
	6,
	'2005-11-18'
),
(
	'Harry Potter and the Order of the Phoenix',
	'With their warning about Lord Voldemort''s return scoffed at, Harry and Dumbledore are targeted by the Wizard authorities as an authoritarian bureaucrat slowly seizes power at Hogwarts.',
	'David Yates',
	'J.K. Rowling, Michael Goldenberg',
	'Daniel Radcliffe, Rupert Grint, Emma Watson',
	'harry-potter-5.png',
	6,
	'2007-07-11'
),
(
	'Harry Potter and the Half-Blood Prince',
	'As Harry Potter begins his sixth year at Hogwarts, he discovers an old book marked as "the property of the Half-Blood Prince" and begins to learn more about Lord Voldemort''s dark past.',
	'David Yates',
	'J.K. Rowling, Steve Kloves',
	'Daniel Radcliffe, Rupert Grint, Emma Watson',
	'harry-potter-6.png',
	6,
	'2009-07-15'
),
(
	'Harry Potter and the Deathly Hallows: Part 1',
	'As Harry, Ron, and Hermione race against time and evil to destroy the Horcruxes, they uncover the existence of the three most powerful objects in the wizarding world: the Deathly Hallows.',
	'David Yates',
	'J.K. Rowling, Steve Kloves',
	'Daniel Radcliffe, Rupert Grint, Emma Watson',
	'harry-potter-7.png',
	6,
	'2010-11-19'
),
(
	'Harry Potter and the Deathly Hallows: Part 2',
	'Harry, Ron, and Hermione search for Voldemort''s remaining Horcruxes in their effort to destroy the Dark Lord as the final battle rages on at Hogwarts.',
	'David Yates',
	'J.K. Rowling, Steve Kloves',
	'Daniel Radcliffe, Rupert Grint, Emma Watson',
	'harry-potter-8.png',
	6,
	'2011-07-15'
),
(
	'Insidious',
	'A family looks to prevent evil spirits from trapping their comatose child in a realm called The Further.',
	'James Wan',
	'Leigh Whannell',
	'Patrick Wilson, Rose Byrne, Ty Simpkins',
	'insidious-1.png',
	7,
	'2011-04-01'
),
(
	'Insidious: Chapter 2',
	'The Lamberts believe that they have defeated the spirits that have haunted their family, but they soon discover that evil is not beaten so easily.',
	'James Wan',
	'Leigh Whannell, James Wan',
	'Patrick Wilson, Rose Byrne, Barbara Hershey',
	'insidious-2.png',
	7,
	'2013-09-13'
),
(
	'Insidious: The Last Key',
	'Parapsychologist Dr. Elise Rainier faces her most fearsome and personal haunting yet, as she is drawn back to her ghostly childhood home, where the terror began.',
	'Adam Robitel',
	'Leigh Whannell',
	'Lin Shaye, Leigh Whannell, Angus Sampson',
	'insidious-4.png',
	7,
	'2018-01-05'
),
(
	'Shutter Island',
	'In 1954, a U.S. Marshal investigates the disappearance of a murderer who escaped from a hospital for the criminally insane.',
	'Martin Scorsese',
	'Laeta Kalogridis, Dennis Lehane',
	'Leonardo DiCaprio, Emily Mortimer, Mark Ruffalo',
	'shutter-island.png',
	7,
	'2010-02-19'
),
(
	'Paranormal Activity',
	'After moving into a suburban home, a couple becomes increasingly disturbed by a nightly demonic presence.',
	'Oren Peli',
	'Oren Peli',
	'Katie Featherston, Micah Sloat, Mark Fredrichs',
	'paranormal-activity.png',
	8,
	'2009-10-16'
),
(
	'Paranormal Activity 2',
	'After experiencing what they think are a series of "break-ins", a family sets up security cameras around their home, only to realize that the events unfolding before them are more sinister than they seem.',
	'Tod Williams',
	'Michael R. Perry, Christopher Landon',
	'Katie Featherston, Micah Sloat, Molly Ephraim',
	'paranormal-activity-2.png',
	8,
	'2010-10-22'
),
(
	'Paranormal Activity 3',
	'In 1988, young sisters Katie and Kristi befriend an invisible entity who resides in their home.',
	'Henry Joost, Ariel Schulman',
	'Christopher Landon, Oren Peli',
	'Chloe Csengery, Jessica Tyler Brown, Christopher Nicholas Smith',
	'paranormal-activity-3.png',
	8,
	'2011-10-21'
),
(
	'Paranormal Activity 4',
	'It has been five years since the disappearance of Katie and Hunter, and a suburban family witness strange events in their neighborhood when a woman and a mysterious child move in.',
	'Henry Joost, Ariel Schulman',
	'Christopher Landon, Chad Feehan',
	'Stephen Dunham, Katie Featherston, Matt Shively',
	'paranormal-activity-4.png',
	8,
	'2012-10-19'
),
(
	'Paranormal Activity: The Marked Ones',
	'When a young man becomes the target of a malevolent entity, he must uncover its true intentions before it takes complete control of him.',
	'Christopher Landon',
	'Christopher Landon, Oren Peli',
	'Andrew Jacobs, Jorge Diaz, Gabrielle Walsh',
	'paranormal-activity-5.png',
	8,
	'2014-01-03'
),
(
	'Paranormal Activity: The Ghost Dimension',
	'Using a special camera that can see spirits, a family must protect their daughter from an evil entity with a sinister plan.',
	'Gregory Plotkin',
	'Jason Pagan, Andrew Deutschman',
	'Chris J. Murray, Brit Shaw, Ivy George',
	'paranormal-activity-6.png',
	8,
	'2015-10-23'
),
(
	'Paranormal Activity 7',
	'Moving in together before college starts, four friends discover a gruesome past of their house and the connection to the 1988 incidents.',
	'-',
	'Oren Peli',
	'-',
	'paranormal-activity-7.png',
	8,
	'2022-03-04'
),
(
	'The Notebook',
	'A poor yet passionate young man falls in love with a rich young woman, giving her a sense of freedom, but they are soon separated because of their social differences.',
	'Nick Cassavetes',
	'Jeremy Leven, Jan Sardi',
	'Gena Rowlands, James Garner, Rachel McAdams',
	'the-notebook.png',
	9,
	'2004-06-25'
),
(
	'Titanic',
	'A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.',
	'James Cameron',
	'James Cameron',
	'Leonardo DiCaprio, Kate Winslet, Billy Zane',
	'titanic.png',
	9,
	'1997-12-19'
),
(
	'Dear John',
	'A romantic drama about a soldier who falls for a conservative college student while he''s home on leave.',
	'JLasse Hallström',
	'Jamie Linden, Nicholas Sparks',
	'Channing Tatum, Amanda Seyfried, Richard Jenkins',
	'dear-john.png',
	9,
	'2010-02-05'
),
(
	'The Longest Ride',
	'The lives of a young couple intertwine with a much older man, as he reflects back on a past love.',
	'George Tillman Jr.',
	'Nicholas Sparks, Craig Bolotin',
	'Scott Eastwood, Britt Robertson, Alan Alda',
	'the-longest-ride.png',
	9,
	'2015-04-10'
),
(
	'Star Wars: Episode IV - A New Hope',
	'Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, a Wookiee and two droids to save the galaxy from the Empire''s world-destroying battle station, while also attempting to rescue Princess Leia from the mysterious Darth Vader.',
	'George Lucas',
	'George Lucas',
	'Mark Hamill, Harrison Ford, Carrie Fisher',
	'star-wars-4.png',
	10,
	'1977-05-25'
),
(
	'Star Wars: Episode V - The Empire Strikes Back',
	'After the Rebels are brutally overpowered by the Empire on the ice planet Hoth, Luke Skywalker begins Jedi training with Yoda, while his friends are pursued by Darth Vader and a bounty hunter named Boba Fett all over the galaxy.',
	'Irvin Kershner',
	'Leigh Brackett, Lawrence Kasdan',
	'Mark Hamill, Harrison Ford, Carrie Fisher',
	'star-wars-5.png',
	10,
	'1980-06-20'
),
(
	'Star Wars: Episode VI - Return of the Jedi',
	'After a daring mission to rescue Han Solo from Jabba the Hutt, the Rebels dispatch to Endor to destroy the second Death Star. Meanwhile, Luke struggles to help Darth Vader back from the dark side without falling into the Emperor''s trap.',
	'Richard Marquand',
	'Lawrence Kasdan, George Lucas',
	'Mark Hamill, Harrison Ford, Carrie Fisher',
	'star-wars-6.png',
	10,
	'1983-05-25'
),
(
	'Star Wars: Episode I - The Phantom Menace',
	'Two Jedi escape a hostile blockade to find allies and come across a young boy who may bring balance to the Force, but the long dormant Sith resurface to claim their original glory.',
	'George Lucas',
	'George Lucas',
	'Ewan McGregor, Liam Neeson, Natalie Portman',
	'star-wars-1.png',
	10,
	'1999-05-19'
),
(
	'Star Wars: Episode II - Attack of the Clones',
	'Ten years after initially meeting, Anakin Skywalker shares a forbidden romance with Padmé Amidala, while Obi-Wan Kenobi investigates an assassination attempt on the senator and discovers a secret clone army crafted for the Jedi.',
	'George Lucas',
	'George Lucas, Jonathan Hales',
	'Hayden Christensen, Natalie Portman, Ewan McGregor',
	'star-wars-2.png',
	10,
	'2002-05-16'
),
(
	'Star Wars: Episode III - Revenge of the Sith',
	'Three years into the Clone Wars, the Jedi rescue Palpatine from Count Dooku. As Obi-Wan pursues a new threat, Anakin acts as a double agent between the Jedi Council and Palpatine and is lured into a sinister plan to rule the galaxy.',
	'George Lucas',
	'George Lucas',
	'Hayden Christensen, Natalie Portman, Ewan McGregor',
	'star-wars-3.png',
	10,
	'2005-05-19'
),
(
	'Star Wars: Episode VII - The Force Awakens',
	'As a new threat to the galaxy rises, Rey, a desert scavenger, and Finn, an ex-stormtrooper, must join Han Solo and Chewbacca to search for the one hope of restoring peace.',
	'J.J. Abrams',
	'Lawrence Kasdan, J.J. Abrams',
	'Daisy Ridley, John Boyega, Oscar Isaac',
	'star-wars-7.png',
	10,
	'2015-12-18'
),
(
	'Star Wars: Episode VIII - The Last Jedi',
	'Rey develops her newly discovered abilities with the guidance of Luke Skywalker, who is unsettled by the strength of her powers. Meanwhile, the Resistance prepares for battle with the First Order.',
	'Rian Johnson',
	'Rian Johnson, George Lucas',
	'Daisy Ridley, John Boyega, Mark Hamill',
	'star-wars-8.png',
	10,
	'2017-12-15'
),
(
	'Star Wars: Episode IX - The Rise of Skywalker',
	'The surviving members of the resistance face the First Order once again, and the legendary conflict between the Jedi and the Sith reaches its peak bringing the Skywalker saga to its end.',
	'J.J. Abrams',
	'Chris Terrio, J.J. Abrams',
	'Daisy Ridley, John Boyega, Oscar Isaac',
	'star-wars-9.png',
	10,
	'2019-12-20'
),
(
	'Django Unchained',
	'With the help of a German bounty-hunter, a freed slave sets out to rescue his wife from a brutal plantation-owner in Mississippi.',
	'Quentin Tarantino',
	'Quentin Tarantino',
	'Jamie Foxx, Christoph Waltz, Leonardo DiCaprio',
	'django-unchained.png',
	11,
	'2012-12-25'
),
(
	'News of the World',
	'A Civil War veteran agrees to deliver a girl, taken by the Kiowa people years ago, to her aunt and uncle, against her will. They travel hundreds of miles and face grave dangers as they search for a place that either can call home.',
	'Paul Greengrass',
	'Paul Greengrass, Luke Davies',
	'Tom Hanks, Helena Zengel, Tom Astor',
	'news-of-the-world.png',
	11,
	'2020-12-25'
),
(
	'Tombstone',
	'A successful lawman''s plans to retire anonymously in Tombstone, Arizona are disrupted by the kind of outlaws he was famous for eliminating.',
	'George P. Cosmatos, Kevin Jarre',
	'Kevin Jarre',
	'Kurt Russell, Val Kilmer, Sam Elliott',
	'tombstone.png',
	11,
	'1993-12-25'
),
(
	'The Magnificent Seven',
	'Seven gunmen from a variety of backgrounds are brought together by a vengeful young widow to protect her town from the private army of a destructive industrialist.',
	'Antoine Fuqua',
	'Akira Kurosawa, Shinobu Hashimoto',
	'Denzel Washington, Chris Pratt, Ethan Hawke',
	'the-magnificent-seven.png',
	11,
	'2016-09-23'
),
(
	'The Hateful Eight',
	'In the dead of a Wyoming winter, a bounty hunter and his prisoner find shelter in a cabin currently inhabited by a collection of nefarious characters.',
	'Quentin Tarantino',
	'Quentin Tarantino',
	'Samuel L. Jackson, Kurt Russell, Jennifer Jason Leigh',
	'the-hateful-eight.png',
	11,
	'2015-12-30'
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

CREATE TABLE IF NOT EXISTS comment (
    id serial PRIMARY KEY,
    text text NOT NULL,
    user_id int NOT NULL,
        CONSTRAINT fk_account FOREIGN KEY(user_id) REFERENCES account(id)
            ON DELETE CASCADE ON UPDATE CASCADE,
    movie_id int NOT NULL,
        CONSTRAINT fk_movie FOREIGN KEY(movie_id) REFERENCES movie(id)
             ON DELETE CASCADE ON UPDATE CASCADE,
    created_at timestamp DEFAULT current_timestamp
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
