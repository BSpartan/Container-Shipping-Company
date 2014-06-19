--------------------------------------------------------
--  File created - donderdag-juni-19-2014   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Sequence CONTAINER_TYPE_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "LP22"."CONTAINER_TYPE_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence CONTAINERS_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "LP22"."CONTAINERS_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence DESTINATIONS_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "LP22"."DESTINATIONS_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence COSTUMERS_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "LP22"."COSTUMERS_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence FREIGHTERS_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "LP22"."FREIGHTERS_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence MAPPING_CONTAINERS_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "LP22"."MAPPING_CONTAINERS_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence MAPPING_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "LP22"."MAPPING_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Table MAPPING_CONTAINERS
--------------------------------------------------------

  CREATE TABLE "LP22"."MAPPING_CONTAINERS" 
   (	"ID" NUMBER, 
	"POSITIONX" NUMBER, 
	"POSITIONY" NUMBER, 
	"POSITIONZ" NUMBER, 
	"MAPPING_ID" NUMBER, 
	"CONTAINER_ID" NUMBER
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table DESTINATIONS
--------------------------------------------------------

  CREATE TABLE "LP22"."DESTINATIONS" 
   (	"ID" NUMBER, 
	"NAME" VARCHAR2(100 BYTE), 
	"LAND" VARCHAR2(100 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table CONTAINERS
--------------------------------------------------------

  CREATE TABLE "LP22"."CONTAINERS" 
   (	"ID" NUMBER, 
	"ADDITIONALWEIGHT" NUMBER, 
	"GPSCODE" VARCHAR2(100 BYTE), 
	"STATUS" VARCHAR2(100 BYTE), 
	"COSTUMERS_ID" NUMBER, 
	"CONTAINER_TYPE_ID" NUMBER
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table CONTAINER_TYPE
--------------------------------------------------------

  CREATE TABLE "LP22"."CONTAINER_TYPE" 
   (	"ID" NUMBER, 
	"NAME" VARCHAR2(100 BYTE), 
	"VALUABLE" NUMBER, 
	"CHILLED" NUMBER
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table FREIGHTERS
--------------------------------------------------------

  CREATE TABLE "LP22"."FREIGHTERS" 
   (	"ID" NUMBER, 
	"SHIPTYPE" VARCHAR2(100 BYTE), 
	"MAXHEIGHT" NUMBER, 
	"CONTAINERROWS" NUMBER, 
	"CONTAINERSEACHROW" NUMBER, 
	"POWERSUPPLY" NUMBER
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table MAPPING
--------------------------------------------------------

  CREATE TABLE "LP22"."MAPPING" 
   (	"ID" NUMBER, 
	"DESTINATION_ID" NUMBER, 
	"FREIGHTERS_ID" NUMBER
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table COSTUMERS
--------------------------------------------------------

  CREATE TABLE "LP22"."COSTUMERS" 
   (	"ID" NUMBER, 
	"COMPANYNAME" VARCHAR2(100 BYTE), 
	"CONTACTNAME" VARCHAR2(100 BYTE), 
	"KVKNUMBER" NUMBER, 
	"COSTUMERS_ID" NUMBER
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
REM INSERTING into LP22.MAPPING_CONTAINERS
SET DEFINE OFF;
REM INSERTING into LP22.DESTINATIONS
SET DEFINE OFF;
REM INSERTING into LP22.CONTAINERS
SET DEFINE OFF;
REM INSERTING into LP22.CONTAINER_TYPE
SET DEFINE OFF;
REM INSERTING into LP22.FREIGHTERS
SET DEFINE OFF;
REM INSERTING into LP22.MAPPING
SET DEFINE OFF;
REM INSERTING into LP22.COSTUMERS
SET DEFINE OFF;
--------------------------------------------------------
--  DDL for Index SYS_C007335
--------------------------------------------------------

  CREATE UNIQUE INDEX "LP22"."SYS_C007335" ON "LP22"."MAPPING_CONTAINERS" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index SYS_C007329
--------------------------------------------------------

  CREATE UNIQUE INDEX "LP22"."SYS_C007329" ON "LP22"."DESTINATIONS" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index SYS_C007320
--------------------------------------------------------

  CREATE UNIQUE INDEX "LP22"."SYS_C007320" ON "LP22"."CONTAINERS" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index SYS_C007323
--------------------------------------------------------

  CREATE UNIQUE INDEX "LP22"."SYS_C007323" ON "LP22"."CONTAINER_TYPE" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index SYS_C007327
--------------------------------------------------------

  CREATE UNIQUE INDEX "LP22"."SYS_C007327" ON "LP22"."FREIGHTERS" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index SYS_C007331
--------------------------------------------------------

  CREATE UNIQUE INDEX "LP22"."SYS_C007331" ON "LP22"."MAPPING" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index SYS_C007318
--------------------------------------------------------

  CREATE UNIQUE INDEX "LP22"."SYS_C007318" ON "LP22"."COSTUMERS" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  Constraints for Table MAPPING_CONTAINERS
--------------------------------------------------------

  ALTER TABLE "LP22"."MAPPING_CONTAINERS" ADD PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
  ALTER TABLE "LP22"."MAPPING_CONTAINERS" MODIFY ("ID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table DESTINATIONS
--------------------------------------------------------

  ALTER TABLE "LP22"."DESTINATIONS" ADD PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
  ALTER TABLE "LP22"."DESTINATIONS" MODIFY ("ID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table CONTAINERS
--------------------------------------------------------

  ALTER TABLE "LP22"."CONTAINERS" ADD PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
  ALTER TABLE "LP22"."CONTAINERS" MODIFY ("ID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table CONTAINER_TYPE
--------------------------------------------------------

  ALTER TABLE "LP22"."CONTAINER_TYPE" ADD PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
  ALTER TABLE "LP22"."CONTAINER_TYPE" MODIFY ("ID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table FREIGHTERS
--------------------------------------------------------

  ALTER TABLE "LP22"."FREIGHTERS" ADD PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
  ALTER TABLE "LP22"."FREIGHTERS" MODIFY ("ID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table MAPPING
--------------------------------------------------------

  ALTER TABLE "LP22"."MAPPING" ADD PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
  ALTER TABLE "LP22"."MAPPING" MODIFY ("ID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table COSTUMERS
--------------------------------------------------------

  ALTER TABLE "LP22"."COSTUMERS" ADD PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
  ALTER TABLE "LP22"."COSTUMERS" MODIFY ("KVKNUMBER" NOT NULL ENABLE);
  ALTER TABLE "LP22"."COSTUMERS" MODIFY ("CONTACTNAME" NOT NULL ENABLE);
  ALTER TABLE "LP22"."COSTUMERS" MODIFY ("COMPANYNAME" NOT NULL ENABLE);
  ALTER TABLE "LP22"."COSTUMERS" MODIFY ("ID" NOT NULL ENABLE);
--------------------------------------------------------
--  Ref Constraints for Table MAPPING_CONTAINERS
--------------------------------------------------------

  ALTER TABLE "LP22"."MAPPING_CONTAINERS" ADD CONSTRAINT "Containers_id_FK" FOREIGN KEY ("CONTAINER_ID")
	  REFERENCES "LP22"."CONTAINERS" ("ID") ON DELETE CASCADE ENABLE;
  ALTER TABLE "LP22"."MAPPING_CONTAINERS" ADD CONSTRAINT "Mapping_id_FK" FOREIGN KEY ("MAPPING_ID")
	  REFERENCES "LP22"."MAPPING" ("ID") ON DELETE CASCADE ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table CONTAINERS
--------------------------------------------------------

  ALTER TABLE "LP22"."CONTAINERS" ADD CONSTRAINT "Container_type_id" FOREIGN KEY ("CONTAINER_TYPE_ID")
	  REFERENCES "LP22"."CONTAINER_TYPE" ("ID") ON DELETE CASCADE ENABLE;
  ALTER TABLE "LP22"."CONTAINERS" ADD CONSTRAINT "Costumers_id_FK" FOREIGN KEY ("COSTUMERS_ID")
	  REFERENCES "LP22"."COSTUMERS" ("ID") ON DELETE CASCADE ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table MAPPING
--------------------------------------------------------

  ALTER TABLE "LP22"."MAPPING" ADD CONSTRAINT "Destinations_id_FK" FOREIGN KEY ("DESTINATION_ID")
	  REFERENCES "LP22"."DESTINATIONS" ("ID") ON DELETE CASCADE ENABLE;
  ALTER TABLE "LP22"."MAPPING" ADD CONSTRAINT "Freighter_id_FK" FOREIGN KEY ("FREIGHTERS_ID")
	  REFERENCES "LP22"."FREIGHTERS" ("ID") ON DELETE CASCADE ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table COSTUMERS
--------------------------------------------------------

  ALTER TABLE "LP22"."COSTUMERS" ADD CONSTRAINT "Customers_id_FK" FOREIGN KEY ("COSTUMERS_ID")
	  REFERENCES "LP22"."COSTUMERS" ("ID") ON DELETE CASCADE ENABLE;
--------------------------------------------------------
--  DDL for Trigger MAPPING_CONTAINERS_AI_TRIG
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "LP22"."MAPPING_CONTAINERS_AI_TRIG" 
        BEFORE INSERT ON MAPPING_CONTAINERS
        FOR EACH ROW
        BEGIN
          SELECT MAPPING_CONTAINERS_seq.nextval
          INTO :new.id
          FROM dual;
        END;
/
ALTER TRIGGER "LP22"."MAPPING_CONTAINERS_AI_TRIG" ENABLE;
--------------------------------------------------------
--  DDL for Trigger COSTUMERS_AI_TRIG
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "LP22"."COSTUMERS_AI_TRIG" 
        BEFORE INSERT ON COSTUMERS
        FOR EACH ROW
        BEGIN
          SELECT COSTUMERS_seq.nextval
          INTO :new.id
          FROM dual;
        END;
/
ALTER TRIGGER "LP22"."COSTUMERS_AI_TRIG" ENABLE;
--------------------------------------------------------
--  DDL for Trigger DESTINATIONS_AI_TRIG
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "LP22"."DESTINATIONS_AI_TRIG" 
        BEFORE INSERT ON DESTINATIONS
        FOR EACH ROW
        BEGIN
          SELECT DESTINATIONS_seq.nextval
          INTO :new.id
          FROM dual;
        END;
/
ALTER TRIGGER "LP22"."DESTINATIONS_AI_TRIG" ENABLE;
--------------------------------------------------------
--  DDL for Trigger CONTAINER_TYPE_AI_TRIG
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "LP22"."CONTAINER_TYPE_AI_TRIG" 
        BEFORE INSERT ON CONTAINER_TYPE
        FOR EACH ROW
        BEGIN
          SELECT CONTAINER_TYPE_seq.nextval
          INTO :new.id
          FROM dual;
        END;
/
ALTER TRIGGER "LP22"."CONTAINER_TYPE_AI_TRIG" ENABLE;
--------------------------------------------------------
--  DDL for Trigger CONTAINERS_AI_TRIG
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "LP22"."CONTAINERS_AI_TRIG" 
        BEFORE INSERT ON CONTAINERS
        FOR EACH ROW
        BEGIN
          SELECT CONTAINERS_seq.nextval
          INTO :new.id
          FROM dual;
        END;
/
ALTER TRIGGER "LP22"."CONTAINERS_AI_TRIG" ENABLE;
--------------------------------------------------------
--  DDL for Trigger MAPPING_AI_TRIG
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "LP22"."MAPPING_AI_TRIG" 
        BEFORE INSERT ON MAPPING
        FOR EACH ROW
        BEGIN
          SELECT MAPPING_seq.nextval
          INTO :new.id
          FROM dual;
        END;
/
ALTER TRIGGER "LP22"."MAPPING_AI_TRIG" ENABLE;
--------------------------------------------------------
--  DDL for Trigger FREIGHTERS_AI_TRIG
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "LP22"."FREIGHTERS_AI_TRIG" 
        BEFORE INSERT ON FREIGHTERS
        FOR EACH ROW
        BEGIN
          SELECT FREIGHTERS_seq.nextval
          INTO :new.id
          FROM dual;
        END;
/
ALTER TRIGGER "LP22"."FREIGHTERS_AI_TRIG" ENABLE;