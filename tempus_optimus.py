#!/usr/bin/env python3

import datetime, time

year_rome_was_founded_bce = 753

datetime.timedelta


class Utc(datetime.tzinfo):
    def fromutc(self, dt):
        return dt

    def utcoffset(self, dt):
        return datetime.timedelta(0)

    def dst(self, dt):
        return datetime.timedelta(0)

    def tzname(self, dt):
        return "UTC"


def optima_date():
    pass


def optima_time():
    pass


if __name__ == "__main__":
    current_year = datetime.datetime.now(Utc()).year - year_rome_was_founded_bce
    print(current_year)

    print(time.time())

    print("UTC")
    print(datetime.datetime.now(Utc()))

    print("local")
    print(datetime.datetime.now())

