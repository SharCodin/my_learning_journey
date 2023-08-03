# Import Flask class which will be WSGI application
from flask import Flask

# Create an instance of Flask which takes __name__ as argument.
# Flask will use this to know where to look for resources such as template and static files.
app = Flask(__name__)


# The decorator app.route tells Flask which URL to trigger the function.
# The function by default returns HTML as string.
@app.route("/")
def hello_world():
    return "<h1>Hello World!</h1>"

# Run the application by using `flask` or `python -m flask`, the name of the application with `--app`, then `run`.
# Example:
# python -m flask --app .\01_quickstart.py run
