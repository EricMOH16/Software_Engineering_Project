DROP TABLE Accounts;

PROMPT CREATING Table Accounts
PROMPT
CREATE Table Accounts
(AccountId numeric(5) NOT NULL,
 Forename varchar2(15) NOT NULL,
 Surname varchar2(15) NOT NULL ,
 PhoneNo numeric(14) NOT NULL,
 Email varchar2(20) NOT NULL,
 Password varchar2(15)NOT NULL,
 Status varchar2(2) NOT NULL,
 CONSTRAINT CHK_Status
    CHECK (Status =  'A' OR Status = 'NA'),
CONSTRAINT pk_Accounts PRIMARY KEY (AccountId));

