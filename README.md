# EFCore2NightlyNet461
Simpler test to use a dbcontext from console and from test
Testing out the nightly builds with .NET 4.6.1 in VS 2017 Preview 3.
DbContext and classes are in one project.
Console App in another.
Console App can successfully execute EF savechanges and simple ToList query.
MSTest in a 3rd project.
It builds but fails at run time seeking System.ValueTuple.dll.
I've had numerous iterations of this testing with the same problem and have attempted many different versions of dotnet installs, nightly builds of packages etc.

