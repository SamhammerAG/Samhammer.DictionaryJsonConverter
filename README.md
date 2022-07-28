# DictionaryJsonConverter
 
 `This package will not be maintained any more`

- Object will be deserialized into nested/recursive Dictionary and List.
- Every child object in the hierarchy will be deserialize to IDictionary<string, object> too.
- Every list will be deserialize to List<"object">.
- PropertyNames will be named with PascalCaseNamingStrategy by default.

## Usage

var dictionary = JsonConvert.DeserializeObject<IDictionary<string, object>>(json, new DictionaryConverter());

## Contribute

#### How to publish package
- set package version in Samhammer.DictionaryJsonConverter.csproj
- create git tag
- dotnet pack -c Release
- nuget push .\bin\Release\Samhammer.DictionaryJsonConverter.*.nupkg NUGET_API_KEY -src https://api.nuget.org/v3/index.json
- (optional) nuget setapikey NUGET_API_KEY -source https://api.nuget.org/v3/index.json
