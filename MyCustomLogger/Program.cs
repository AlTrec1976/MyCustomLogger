using Loger;
using MyCustomLogger;

var work = new Work(new FileLoger());
work.SomeWork();

var err = new Error(new FileLoger());
err.SomeWork();