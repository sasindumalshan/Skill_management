# Skill_management_OLD


<h1>Hello I'm Sasindu Malshan</h1>

<p>This my fist C# Project I Crate this Project For Impure My Skill and C# Lean  <p>

<h4>Data Base is MySql</h4>
<a href="https://drive.google.com/file/d/1aurKX8lGhg1Pwn2I0RzX6fYUGEqDenZC/view?usp=sharing" target="_blank">Download DB</a>
<a href="https://dev.mysql.com/downloads/connector/net/" target="_blank">Download C# DB Connector/NET</a>


<p> Please change your username and password for this project before using it. </p>
<p>Souse path : Skill_management/DBConntection
/DBConection.cs</p>

<h4>connection = new MySqlConnection("host=localhost;<b>user=your_MySql_userName;password=your_MySql_password;</b>database=student;");</h4>


<p>create database student;<br />
use student;<br />
create table user<br />
(<br />
    userName VARCHAR(45),<br />
    password varchar(45)<br />
);<br />
insert into user<br />
values ('admin', '1234');<br />
<br />
create table registration<br />
(<br />
    regNo       Integer,<br />
    firstName   varchar(50),<br />
    lastName    varchar(50),<br />
    dateOfBirth dateTime,<br />
    gender      varchar(50),<br />
    address     varchar(50),<br />
    email       varchar(50),<br />
    mobilePhone Integer,<br />
    homePhone   Integer,<br />
    parentName  varchar(50),<br />
    nic         varchar(50),<br />
    contactNo   Integer<br />
);</p>



<h4>Login Page</h4>

![Screenshot 2023-10-10 020226](https://github.com/sasindumalshan/Skill-Management/assets/109432637/cea87768-58f8-4f88-848f-eab5f2e0826b)

<h4>Register Page</h4>

![Screenshot 2023-10-10 020248](https://github.com/sasindumalshan/Skill-Management/assets/109432637/6e0bb16e-d135-4e85-ad53-95668f1fdd74)
