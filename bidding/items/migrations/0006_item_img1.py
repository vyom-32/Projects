# Generated by Django 3.0.3 on 2020-03-15 09:52

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('items', '0005_item_highest_bidder'),
    ]

    operations = [
        migrations.AddField(
            model_name='item',
            name='img1',
            field=models.ImageField(null=True, upload_to='pics'),
        ),
    ]
