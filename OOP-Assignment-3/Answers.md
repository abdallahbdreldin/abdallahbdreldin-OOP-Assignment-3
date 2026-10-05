# IReadOnlyDictionary<TKey,TValue> 
	- IReadOnlyDictionary<TKey, TValue> is an interface that exposes dictionary data 
	  without exposing methods to modify it. It provides read-only access to the key-value pairs in the dictionary.

	  - regular dictionary: allows adding, removing, and modifying key-value pairs.

	## when to use IReadOnlyDictionary<TKey, TValue>:
	   - when wanr to expose a dictionary to consumers of your class but want to prevent them from modifying it.

	## why would a public method return one instead of a Dictionary ?
	 - to encapsulate the internal data structure and prevent external code from modifying it
	 so the caller gets permission to read the data but not change it.

# SortedDictionary<TKey, TValue>
	- SortedDictionary<TKey, TValue> is a collection that stores key-value pairs in sorted order based on the keys.
	but it's slower in lookup o(log n) than a regular dictionary (o(1)) because it maintains the sorted order of the keys.

	## when to use SortedDictionary<TKey, TValue>:
	 - when you need to deal with sorted data and need to maintain the order of the keys.

# Pick the right collection based on your needs:
	
	S1 Find a student by national ID — thousands of times a day.
		- Dictionary => fast lookup by national ID.

	S2 Keep the tags of a course. The same tag must never be stored twice.
		- HashSet => prevents duplicates and allows fast lookup.

	S3 Keep a student's grades in the order they were entered. The same grade can appear more than once. =>
		- List<T> => maintains insertion order and allows duplicates.

	S4 A public method returns the course price list. Callers can read prices but must not add or change any.
		- IReadOnlyDictionary<TKey, TValue> => provides read-only access to the price list.

	S5 A timetable keyed by session start time. Sessions are added at any moment, and it must always print in
	time order.
		- SortedDictionary<TKey, TValue> => maintains keys in sorted order.
	S6 A method returns results that the caller only loops over once — and may stop early.
		- IEnumerable<T> => allows for efficient iteration without loading all results into memory.