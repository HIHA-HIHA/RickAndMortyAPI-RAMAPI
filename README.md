# RickAndMortyAPI (RAMAPI)
 Work with RickAndMortyAPI
C#
 usage:
need lib Newtonsoft.Json
 
```c#
using RickAndMortyAPI;

namespace SomeNameSpace
{
	class SomeClass
	{
		void SomeMethod()
		{
			// it exampel
	  		API.IdCharacter = id character (int);
			
			Response response = await API.GetInfoAboutCity();
			
			string Name = response.Name;
			string Status = response.Status;
			
			// some code.
			
			
		}
	}
}
```
