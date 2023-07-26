from django.db import models


class Blog(models.Model):
    title = models.CharField(max_length=100)
    description = models.TextField()
    date_posted = models.DateTimeField(auto_now_add=True)
