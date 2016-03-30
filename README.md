#LogInterface

Provides an interface for different types of logging.

I like to use the same logging interface in everything. Then I can swap out log types on the fly. System logs? Logs to file? Logs to the console? Unity console logs? There are a lot of logging options, and I don't like commitment.

Also, I like to be able to use a "test log" in unit tests. It doesn't output or write anything, giving me clean tests with reduced places for things to go wrong. If I'm trying to test class ComplicatedStateInterface, I don't also want to be testing its logger!

