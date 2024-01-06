IMessageWriter writer = new ConsoleMessageWriter();
var salutation = new Salutation(writer);
salutation.Exclaim();
