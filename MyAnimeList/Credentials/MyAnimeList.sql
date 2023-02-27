--
-- PostgreSQL database dump
--

-- Dumped from database version 13.4
-- Dumped by pg_dump version 13.1

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: animesayısıekleme(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public."animesayısıekleme"() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
DECLARE
    miktar NUMERIC;
BEGIN
     miktar := (SELECT COUNT("ID") FROM "public"."Anime");
   
     UPDATE "FinalAnimeCount" SET "Total Number" = miktar;

     RETURN NULL;
END
$$;


ALTER FUNCTION public."animesayısıekleme"() OWNER TO postgres;

--
-- Name: azalma(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.azalma() RETURNS trigger
    LANGUAGE plpgsql
    AS $$

DECLARE

animeid INTEGER;



BEGIN
     
    animeid=OLD."Anime_ID";
        UPDATE "Anime" SET "Episodes" = "Episodes" - 1 WHERE "ID" = animeid;
       
  
    RETURN NEW;
     
END
$$;


ALTER FUNCTION public.azalma() OWNER TO postgres;

--
-- Name: counter(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.counter() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
DECLARE

animeid INTEGER;



BEGIN
     
    animeid=NEW."Anime_ID";
        UPDATE "Anime" SET "Episodes" = "Episodes" + 1 WHERE "ID" = animeid;
       
    RETURN NEW;
     
END
$$;


ALTER FUNCTION public.counter() OWNER TO postgres;

--
-- Name: dilegöreanime(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public."dilegöreanime"("dilıd" integer) RETURNS TABLE(namee text, episodee smallint, countryy text, genree text, languagee text, certificatee text, producerr text, distrii text)
    LANGUAGE plpgsql
    AS $$
DECLARE
    
   
BEGIN
     
     
     
     RETURN QUERY  SELECT "Anime"."AnimeName",
    "Anime"."Episodes",
    "Country"."Country",
    "Genre"."Name" AS "Genre",
    "Language"."Language",
    "Certificate"."Certificate",
   "t1"."Company" as "Producer",
    "t2"."Company" as  "Distributor"
   FROM "Anime"
     JOIN "Country" ON "Anime"."Country" = "Country"."ID"
     JOIN "Language" ON "Anime"."Language" = "Language"."ID"
     JOIN "Certificate" ON "Anime"."Certificate" = "Certificate"."ID"
     JOIN "Distribution" ON "Anime"."Distrubutor" = "Distribution"."Company_ID"
     JOIN "Production" ON "Anime"."Producer" = "Production"."Company_ID"
     join "Company" "t1" on "Production"."Company_ID"= "t1"."ID"
     join "Company" "t2" on "Distribution"."Company_ID"= "t2"."ID"
     JOIN "Genre" ON "Anime"."Genre" = "Genre"."ID"
                    WHERE "Language"."ID" = dilıd ;
     
END
$$;


ALTER FUNCTION public."dilegöreanime"("dilıd" integer) OWNER TO postgres;

--
-- Name: mainekle(smallint, text); Type: PROCEDURE; Schema: public; Owner: postgres
--

CREATE PROCEDURE public.mainekle(animeidd smallint, gereken text)
    LANGUAGE plpgsql
    AS $$
DECLARE Anime_IDD integer;

BEGIN

INSERT INTO "public"."Character"("Character_ID","Name","Anime_ID","CharacterType")
VALUES (nextval('"public"."characterid"'),gereken,animeidd,'M' ) RETURNING "Character_ID" INTO Anime_IDD;

INSERT INTO "public"."MainCharacter"("Character_ID","Main")
VALUES (Anime_IDD,gereken);

END 
$$;


ALTER PROCEDURE public.mainekle(animeidd smallint, gereken text) OWNER TO postgres;

--
-- Name: nekadarsürer(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public."nekadarsürer"(animeninkendisi integer) RETURNS double precision
    LANGUAGE plpgsql
    AS $$
DECLARE
    miktar double PRECISION;
    tamamı DOUBLE PRECISION;
BEGIN
     miktar := (SELECT sum("Time") FROM "public"."Episode" WHERE "Anime_ID" = animeninkendisi ); 
      tamamı := (SELECT Count("ID") FROM "public"."Episode" WHERE "Anime_ID" = animeninkendisi ); 
     RETURN miktar/60 ;
END
$$;


ALTER FUNCTION public."nekadarsürer"(animeninkendisi integer) OWNER TO postgres;

--
-- Name: ortalamabolum(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.ortalamabolum(animeninkendisi integer) RETURNS double precision
    LANGUAGE plpgsql
    AS $$
DECLARE
    miktar double PRECISION;
    tamamı DOUBLE PRECISION;
BEGIN
     miktar := (SELECT sum("Time") FROM "public"."Episode" WHERE "Anime_ID" = animeninkendisi ); 
      tamamı := (SELECT Count("ID") FROM "public"."Episode" WHERE "Anime_ID" = animeninkendisi ); 
     RETURN miktar/tamamı ;
END
$$;


ALTER FUNCTION public.ortalamabolum(animeninkendisi integer) OWNER TO postgres;

--
-- Name: sideekle(smallint, text); Type: PROCEDURE; Schema: public; Owner: postgres
--

CREATE PROCEDURE public.sideekle(animeidd smallint, gereken text)
    LANGUAGE plpgsql
    AS $$
DECLARE Anime_IDD integer;

BEGIN

INSERT INTO "public"."Character"("Character_ID","Name","Anime_ID","CharacterType")
VALUES (nextval('"public"."characterid"'),gereken,animeidd,'S' ) RETURNING "Character_ID" INTO Anime_IDD;

INSERT INTO "public"."SideCharacter"("Character_ID","Side")
VALUES (Anime_IDD,gereken);

END 
$$;


ALTER PROCEDURE public.sideekle(animeidd smallint, gereken text) OWNER TO postgres;

--
-- Name: villianekle(smallint, text); Type: PROCEDURE; Schema: public; Owner: postgres
--

CREATE PROCEDURE public.villianekle(animeidd smallint, gereken text)
    LANGUAGE plpgsql
    AS $$
DECLARE Anime_IDD integer;

BEGIN

INSERT INTO "public"."Character"("Character_ID","Name","Anime_ID","CharacterType")
VALUES (nextval('"public"."characterid"'),gereken,animeidd,'V' ) RETURNING "Character_ID" INTO Anime_IDD;

INSERT INTO "public"."Villian"("Character_ID","Villian")
VALUES (Anime_IDD,gereken);

END 
$$;


ALTER PROCEDURE public.villianekle(animeidd smallint, gereken text) OWNER TO postgres;

--
-- Name: yedekleme(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.yedekleme() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
   

  INSERT INTO "YedekBolum" 
("ID", "Name", "Time","Sezon", "Anime_ID")
VALUES (OLD."ID",OLD."Episode Name", OLD."Time",OLD."Season",OLD."Anime_ID");
    RETURN NEW;
END;
$$;


ALTER FUNCTION public.yedekleme() OWNER TO postgres;

--
-- Name: yetermi(integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.yetermi(animeninkendisi integer, "yası" integer) RETURNS text
    LANGUAGE plpgsql
    AS $$
DECLARE
    sınır INTEGER;
    certifi INTEGER;
BEGIN
     certifi = (SELECT "Certificate" FROM "public"."Anime" WHERE "ID" = animeninkendisi ); 
     sınır = (SELECT "Certificate" FROM "public"."Certificate" WHERE "ID" = certifi ); 
     
     IF yası >= sınır THEN
     RETURN 'İzleyebilirsin :)';
     ELSE
     RETURN 'İzleyemezsin !!!';
     END IF;
     
END
$$;


ALTER FUNCTION public.yetermi(animeninkendisi integer, "yası" integer) OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: Anime; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Anime" (
    "ID" smallint NOT NULL,
    "AnimeName" text NOT NULL,
    "Runtime" smallint,
    "Rank" smallint,
    "Episodes" smallint DEFAULT '0'::smallint NOT NULL,
    "Country" smallint,
    "Genre" smallint NOT NULL,
    "Language" smallint,
    "Certificate" smallint,
    "Distrubutor" smallint,
    "Producer" smallint
);


ALTER TABLE public."Anime" OWNER TO postgres;

--
-- Name: Certificate; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Certificate" (
    "ID" smallint NOT NULL,
    "Certificate" text NOT NULL
);


ALTER TABLE public."Certificate" OWNER TO postgres;

--
-- Name: Company; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Company" (
    "ID" smallint NOT NULL,
    "Company" text NOT NULL,
    "Tipi" character(1) NOT NULL
);


ALTER TABLE public."Company" OWNER TO postgres;

--
-- Name: Country; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Country" (
    "ID" smallint NOT NULL,
    "Country" text NOT NULL
);


ALTER TABLE public."Country" OWNER TO postgres;

--
-- Name: Distribution; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Distribution" (
    "Company_ID" smallint NOT NULL,
    "Yer" text DEFAULT 'Online'::text NOT NULL
);


ALTER TABLE public."Distribution" OWNER TO postgres;

--
-- Name: Genre; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Genre" (
    "ID" smallint NOT NULL,
    "Name" text NOT NULL
);


ALTER TABLE public."Genre" OWNER TO postgres;

--
-- Name: Language; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Language" (
    "ID" smallint NOT NULL,
    "Language" text NOT NULL
);


ALTER TABLE public."Language" OWNER TO postgres;

--
-- Name: Production; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Production" (
    "Company_ID" smallint NOT NULL,
    "Bütce" smallint DEFAULT '30000'::smallint NOT NULL
);


ALTER TABLE public."Production" OWNER TO postgres;

--
-- Name: AnimeGoruntu; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public."AnimeGoruntu" AS
 SELECT "Anime"."AnimeName",
    "Anime"."Episodes",
    "Country"."Country",
    "Genre"."Name" AS "Genre",
    "Language"."Language",
    "Certificate"."Certificate",
    t1."Company" AS "Producer",
    t2."Company" AS "Distributor"
   FROM ((((((((public."Anime"
     JOIN public."Country" ON (("Anime"."Country" = "Country"."ID")))
     JOIN public."Language" ON (("Anime"."Language" = "Language"."ID")))
     JOIN public."Certificate" ON (("Anime"."Certificate" = "Certificate"."ID")))
     JOIN public."Distribution" ON (("Anime"."Distrubutor" = "Distribution"."Company_ID")))
     JOIN public."Production" ON (("Anime"."Producer" = "Production"."Company_ID")))
     JOIN public."Company" t1 ON (("Production"."Company_ID" = t1."ID")))
     JOIN public."Company" t2 ON (("Distribution"."Company_ID" = t2."ID")))
     JOIN public."Genre" ON (("Anime"."Genre" = "Genre"."ID")));


ALTER TABLE public."AnimeGoruntu" OWNER TO postgres;

--
-- Name: Character; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Character" (
    "Character_ID" smallint NOT NULL,
    "Name" character varying(40) NOT NULL,
    "Anime_ID" smallint,
    "CharacterType" character(1) NOT NULL
);


ALTER TABLE public."Character" OWNER TO postgres;

--
-- Name: Episode; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Episode" (
    "ID" smallint NOT NULL,
    "Episode Name" text NOT NULL,
    "Time" smallint NOT NULL,
    "Season" smallint NOT NULL,
    "Anime_ID" smallint NOT NULL
);


ALTER TABLE public."Episode" OWNER TO postgres;

--
-- Name: FinalAnimeCount; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."FinalAnimeCount" (
    "Total Number" integer NOT NULL
);


ALTER TABLE public."FinalAnimeCount" OWNER TO postgres;

--
-- Name: MainCharacter; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."MainCharacter" (
    "Character_ID" integer NOT NULL,
    "Main" character varying(40)
);


ALTER TABLE public."MainCharacter" OWNER TO postgres;

--
-- Name: SideCharacter; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."SideCharacter" (
    "Character_ID" integer NOT NULL,
    "Side" character varying(40)
);


ALTER TABLE public."SideCharacter" OWNER TO postgres;

--
-- Name: Villian; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Villian" (
    "Character_ID" integer NOT NULL,
    "Villian" character varying(40)
);


ALTER TABLE public."Villian" OWNER TO postgres;

--
-- Name: YedekBolum; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."YedekBolum" (
    "ID" smallint NOT NULL,
    "Name" text NOT NULL,
    "Time" text NOT NULL,
    "Sezon" text NOT NULL,
    "Anime_ID" text NOT NULL
);


ALTER TABLE public."YedekBolum" OWNER TO postgres;

--
-- Name: animeid; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.animeid
    START WITH 10000
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.animeid OWNER TO postgres;

--
-- Name: animeid; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.animeid OWNED BY public."Anime"."ID";


--
-- Name: bolumid; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.bolumid
    START WITH 3000
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.bolumid OWNER TO postgres;

--
-- Name: bolumid; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.bolumid OWNED BY public."Episode"."ID";


--
-- Name: characterid; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.characterid
    START WITH 20000
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.characterid OWNER TO postgres;

--
-- Name: characterid; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.characterid OWNED BY public."Character"."Character_ID";


--
-- Name: Anime ID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Anime" ALTER COLUMN "ID" SET DEFAULT nextval('public.animeid'::regclass);


--
-- Name: Character Character_ID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Character" ALTER COLUMN "Character_ID" SET DEFAULT nextval('public.characterid'::regclass);


--
-- Name: Episode ID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Episode" ALTER COLUMN "ID" SET DEFAULT nextval('public.bolumid'::regclass);


--
-- Data for Name: Anime; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Anime" VALUES
	(10020, 'Bleach', 10, 1, 0, 4003, 2001, 3003, 1003, 7001, 7002);


--
-- Data for Name: Certificate; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Certificate" VALUES
	(1001, '7'),
	(1002, '13'),
	(1003, '18');


--
-- Data for Name: Character; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Company; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Company" VALUES
	(7001, 'Disney', 'D'),
	(7002, 'Paramount', 'P'),
	(7003, 'Marvel', 'D'),
	(7004, 'DC', 'P');


--
-- Data for Name: Country; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Country" VALUES
	(4001, 'USA'),
	(4002, 'Japan'),
	(4003, 'Turkey');


--
-- Data for Name: Distribution; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Distribution" VALUES
	(7001, 'Online'),
	(7003, 'TV');


--
-- Data for Name: Episode; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: FinalAnimeCount; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."FinalAnimeCount" VALUES
	(1);


--
-- Data for Name: Genre; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Genre" VALUES
	(2001, 'Action'),
	(2002, 'Fantasy'),
	(2003, 'Romance');


--
-- Data for Name: Language; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Language" VALUES
	(3001, 'English'),
	(3002, 'Japanese'),
	(3003, 'Turkish');


--
-- Data for Name: MainCharacter; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Production; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Production" VALUES
	(7002, 30000),
	(7004, 20000);


--
-- Data for Name: SideCharacter; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Villian; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: YedekBolum; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."YedekBolum" VALUES
	(3013, 'ads', '30', '1', '10020'),
	(3014, 'adss', '30', '1', '10020');


--
-- Name: animeid; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.animeid', 10025, true);


--
-- Name: bolumid; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.bolumid', 3014, true);


--
-- Name: characterid; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.characterid', 20009, true);


--
-- Name: Certificate Certificate_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Certificate"
    ADD CONSTRAINT "Certificate_pkey" PRIMARY KEY ("ID");


--
-- Name: Character CharacterPK; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Character"
    ADD CONSTRAINT "CharacterPK" PRIMARY KEY ("Character_ID");


--
-- Name: Company Company_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Company"
    ADD CONSTRAINT "Company_pkey" PRIMARY KEY ("ID");


--
-- Name: Distribution Distribution_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Distribution"
    ADD CONSTRAINT "Distribution_pkey" PRIMARY KEY ("Company_ID");


--
-- Name: Episode Episode_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Episode"
    ADD CONSTRAINT "Episode_pkey" PRIMARY KEY ("ID");


--
-- Name: Production Production_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Production"
    ADD CONSTRAINT "Production_pkey" PRIMARY KEY ("Company_ID");


--
-- Name: MainCharacter danismanPK; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."MainCharacter"
    ADD CONSTRAINT "danismanPK" PRIMARY KEY ("Character_ID");


--
-- Name: Villian satisTemsilcisi; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Villian"
    ADD CONSTRAINT "satisTemsilcisi" PRIMARY KEY ("Character_ID");


--
-- Name: SideCharacter satisTemsilcisiPK; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."SideCharacter"
    ADD CONSTRAINT "satisTemsilcisiPK" PRIMARY KEY ("Character_ID");


--
-- Name: Anime unique_Anime_ID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Anime"
    ADD CONSTRAINT "unique_Anime_ID" PRIMARY KEY ("ID");


--
-- Name: Country unique_Country_ID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Country"
    ADD CONSTRAINT "unique_Country_ID" PRIMARY KEY ("ID");


--
-- Name: Genre unique_Genre_ID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Genre"
    ADD CONSTRAINT "unique_Genre_ID" PRIMARY KEY ("ID");


--
-- Name: Language unique_Language_ID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Language"
    ADD CONSTRAINT "unique_Language_ID" PRIMARY KEY ("ID");


--
-- Name: Anime animArtınca; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER "animArtınca" AFTER INSERT OR DELETE ON public."Anime" FOR EACH ROW EXECUTE FUNCTION public."animesayısıekleme"();


--
-- Name: Episode bölümArtınca; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER "bölümArtınca" AFTER INSERT ON public."Episode" FOR EACH ROW EXECUTE FUNCTION public.counter();


--
-- Name: Episode bölümAzalınca; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER "bölümAzalınca" AFTER DELETE ON public."Episode" FOR EACH ROW EXECUTE FUNCTION public.azalma();


--
-- Name: Episode yedekleme; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER yedekleme AFTER DELETE ON public."Episode" FOR EACH ROW EXECUTE FUNCTION public.yedekleme();


--
-- Name: Character Anime2Character; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Character"
    ADD CONSTRAINT "Anime2Character" FOREIGN KEY ("Anime_ID") REFERENCES public."Anime"("ID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Episode Anime2Episode; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Episode"
    ADD CONSTRAINT "Anime2Episode" FOREIGN KEY ("Anime_ID") REFERENCES public."Anime"("ID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Anime AnimeCountry; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Anime"
    ADD CONSTRAINT "AnimeCountry" FOREIGN KEY ("Country") REFERENCES public."Country"("ID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Anime Certificate2Anime; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Anime"
    ADD CONSTRAINT "Certificate2Anime" FOREIGN KEY ("Certificate") REFERENCES public."Certificate"("ID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: MainCharacter CharacterMain; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."MainCharacter"
    ADD CONSTRAINT "CharacterMain" FOREIGN KEY ("Character_ID") REFERENCES public."Character"("Character_ID") ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: SideCharacter CharacterSide; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."SideCharacter"
    ADD CONSTRAINT "CharacterSide" FOREIGN KEY ("Character_ID") REFERENCES public."Character"("Character_ID") ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Villian CharacterVillian; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Villian"
    ADD CONSTRAINT "CharacterVillian" FOREIGN KEY ("Character_ID") REFERENCES public."Character"("Character_ID") ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Distribution Company2Distribution; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Distribution"
    ADD CONSTRAINT "Company2Distribution" FOREIGN KEY ("Company_ID") REFERENCES public."Company"("ID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Production Company2Production; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Production"
    ADD CONSTRAINT "Company2Production" FOREIGN KEY ("Company_ID") REFERENCES public."Company"("ID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Anime Distribution2An,me; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Anime"
    ADD CONSTRAINT "Distribution2An,me" FOREIGN KEY ("Distrubutor") REFERENCES public."Distribution"("Company_ID") MATCH FULL;


--
-- Name: Anime Genre2Anime; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Anime"
    ADD CONSTRAINT "Genre2Anime" FOREIGN KEY ("Genre") REFERENCES public."Genre"("ID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Anime Language2Anime; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Anime"
    ADD CONSTRAINT "Language2Anime" FOREIGN KEY ("Language") REFERENCES public."Language"("ID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Anime Producer2Anime; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Anime"
    ADD CONSTRAINT "Producer2Anime" FOREIGN KEY ("Producer") REFERENCES public."Production"("Company_ID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- PostgreSQL database dump complete
--

