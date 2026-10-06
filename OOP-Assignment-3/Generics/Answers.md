## what is the same between the two stores, and what is different?
	- both are same structure and same behavior
	- the only difference is the entity type they store.



# after using a generic store, what is the difference between the two stores?
	- The difference is that one store can store any type of entity, while the other store can only store a specific type of entity.
	- but there is a compile error in id 
	'T' does not contain a definition for 'Id' and no accessible extension method 'Id' accepting a first argument of type 'T' could be found (are you missing a using directive or an assembly reference?)
	- because the compile doesn't know if the entity type has an Id property or not, so it cannot access it.
