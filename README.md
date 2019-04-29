# DictionaryJsonConverter

- Object will be deserialized into nested/recursive Dictionary and List.
- Every child object in the hierarchy will be deserialize to IDictionary<string, object> too.
- Every list will be deserialize to List<"object">.

## Usage

var dictionary = JsonConvert.DeserializeObject<IDictionary<string, object>>(json, new DictionaryConverter());
