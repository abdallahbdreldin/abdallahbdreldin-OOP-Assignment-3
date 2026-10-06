## what is the same between the two stores, and what is different?
	- both are same structure and same behavior
	- the only difference is the entity type they store.



# after using a generic store, what is the difference between the two stores?
	- The difference is that one store can store any type of entity, while the other store can only store a specific type of entity.
	- but there is a compile error in id 
	'T' does not contain a definition for 'Id' and no accessible extension method 'Id' accepting a first argument of type 'T' could be found (are you missing a using directive or an assembly reference?)
	- because the compile doesn't know if the entity type has an Id property or not, so it cannot access it.

## Why `GenericStore<string>()` must NOT compile

GenericStore<T> is declared with a generic constraint `where T : class, IHasId`. That means the type parameter T must be a reference type that implements the IHasId interface (it must expose an Id property).

string does not implement IHasId, so trying to instantiate GenericStore<string> would violate the generic constraint and the code would fail to compile.

