CREATE TABLE STUDENT
(
  ID             VARCHAR2(255) not null,
  NAME 			 VARCHAR2(255) ,
  CONSTRAINT constraint_name PRIMARY KEY ID
);


CREATE TABLE GRADES
(
  STUDENT_ID             VARCHAR2(255) not null,
  COURSE_ID             VARCHAR2(255) not null,
   			 VARCHAR2(255) ,
  GRADE 			 		INTEGER ,
  CONSTRAINT constraint_name PRIMARY KEY (STUDENT_ID,COURSE_ID)
);
