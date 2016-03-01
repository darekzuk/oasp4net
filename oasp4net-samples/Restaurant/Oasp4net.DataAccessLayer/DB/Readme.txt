Where is the DB file ?

To simplify the development a local DB file is being created upon first Context access (i.e. REST call)
After creation the DB file remains in the DEBUG directory being migrated and seeded automatically.
To reset the DB state simply clean the start-up project (ServiceLayer by default) or delete the DB file RestaurantDb.mdf 