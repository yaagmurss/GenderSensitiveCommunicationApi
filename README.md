# YagmurSolmaz-Week2-Homework

This project is a sample Api that you can post an entry.
If you **try to post forbidden words in text area, you wil get an error**.

Forbidden Words List:
- "bayan",
- "insanoğlu",
- "bilim adamı",
- "kadın işi",
- "erkek işi",
- "elinin hamuru"

Custom MiddleWare called **UseCustomExceptionMiddleware** is written to catch the Exception called **LanguageViolationException**.
