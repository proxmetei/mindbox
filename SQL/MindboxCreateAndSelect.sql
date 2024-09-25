
-- create
CREATE TABLE IF NOT EXISTS "products" (
	"id" serial NOT NULL UNIQUE,
	"name" varchar(255) NOT NULL,
	PRIMARY KEY ("id")
);

CREATE TABLE IF NOT EXISTS "cartegories" (
	"id" serial NOT NULL UNIQUE,
	"name" varchar(255) NOT NULL,
	PRIMARY KEY ("id")
);

CREATE TABLE IF NOT EXISTS "products_categories" (
	"product_id" bigint NOT NULL,
	"category_id" bigint NOT NULL
);



ALTER TABLE "products_categories" ADD CONSTRAINT "products_categories_fk0" FOREIGN KEY ("product_id") REFERENCES "products"("id");

ALTER TABLE "products_categories" ADD CONSTRAINT "products_categories_fk1" FOREIGN KEY ("category_id") REFERENCES "cartegories"("id");

-- insert
INSERT INTO products VALUES (1,'prod1');
INSERT INTO products VALUES (2,'prod2');
INSERT INTO products VALUES (3,'prod3');
INSERT INTO products VALUES (4,'prod4');
INSERT INTO cartegories VALUES (1,'cat1');
INSERT INTO cartegories VALUES (2,'cat2');
INSERT INTO products_categories VALUES (1,1);
INSERT INTO products_categories VALUES (1,2);
INSERT INTO products_categories VALUES (2,2);
INSERT INTO products_categories VALUES (3,1);
INSERT INTO products_categories VALUES (4,1);
INSERT INTO products_categories VALUES (4,2);

-- fetch 
SELECT a.name, c.name FROM products a inner join products_categories b on a.id=b.product_id inner join cartegories c on c.id=b.category_id  ;
