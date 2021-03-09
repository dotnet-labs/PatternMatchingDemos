# Using Pattern Matching to Avoid Massive "if" Statements

<a href='https://ko-fi.com/changhuixu' target='_blank'><img height='36' style='border:0px;height:36px;' src='https://cdn.ko-fi.com/cdn/kofi3.png?v=2' border='0' alt='Buy Me a Coffee at ko-fi.com' /></a>

## [Medium Article](https://levelup.gitconnected.com/using-pattern-matching-to-avoid-massive-if-statements-ce286e2f0ea5)

With the increasing complexity of business logic in our applications, the "if" statements in the code will become more and more bloated, thus hard to read and maintain. One word of caution: I don't mean to say that "if" statements are evil or code-smell. I do believe "if" statements have their advantages in some use cases, but for the use cases discussed today, we will try to find an alternative way to write easy-to-read code.

This blog post will show you a way to avoid clunky or nested "if" statements by using Pattern Matching and decision tables. I will first explain the use cases of decision tables, then illustrate the implementation using pattern matching in C#.

[Update: 04/27/2020]

Added an example to rewrite a demo Rules Pattern ([source link](https://www.michael-whelan.net/rules-design-pattern/)), to show off Pattern Matching

## License

Feel free to use the code in this repository as it is under MIT license.

<a href='https://ko-fi.com/changhuixu' target='_blank'><img height='36' style='border:0px;height:36px;' src='https://cdn.ko-fi.com/cdn/kofi3.png?v=2' border='0' alt='Buy Me a Coffee at ko-fi.com' /></a>
