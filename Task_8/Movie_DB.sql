create database Movie2;
go 
use Movie2;
go 
-- Create the actor table
create table actor
(
	act_id int primary key,
	act_fname varchar(55) not null,
	act_lname varchar(55) not null,
	act_gender varchar(55) not null
);
-- Movie cast table
create table movie_cast
(
	act_id int,
	move_id int,
	role varchar(55) not null,
	foreign key (act_id) references actor(act_id),
);
alter table movie_cast
add constraint FK_movie_cast_movie foreign key (move_id) references movie(mov_id);
-- director table
create table director
(
	dir_id int primary key,
	dir_fname varchar(55) not null,
	dir_lname varchar(55) not null
);
-- movie direction table
create table movie_direction
(
	dir_id int,
	move_id int,
	foreign key (dir_id) references director(dir_id)
);
-- movie table
create table movie
(
	mov_id int primary key,
	mov_title varchar(50) not null,
	mov_year int not null,
	mov_time int not null,
	mov_lang varchar(50) not null,
	mov_dt_rel date not null,
	mov_rel_country varchar(5) not null
);
-- reviewer table
create table reviewer
(
	rev_id int primary key,
	rev_name varchar(55) not null,
);
-- geners table
create table geners
(
	gen_id int primary key,
	gen_title varchar(55) not null,
);
-- movie geners table
create table movie_geners
(
	mov_id int,
	gen_id int,
	foreign key (mov_id) references movie(mov_id),
	foreign key (gen_id) references geners(gen_id)
);
-- rating table
create table rating
(
	mov_id int,
	rev_id int,
	rev_stars int not null,
	num_o_ratings int not null,
	foreign key (mov_id) references movie(mov_id),
	foreign key (rev_id) references reviewer(rev_id)
);