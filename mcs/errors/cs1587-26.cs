// cs1587-26.cs: XML comment is not placed on a valid language element
// Line: 11
// Compiler options: -doc:dummy.xml -warnaserror -warn:2

using System;

namespace TopNS
{
	class Foo
	{
		public /** invalid comment in field decl */ int field;
	}
}
