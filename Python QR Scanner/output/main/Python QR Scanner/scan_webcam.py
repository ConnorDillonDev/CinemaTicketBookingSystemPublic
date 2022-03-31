import cv2
import pyzbar.pyzbar as pyzbar
import sqlite3
import numpy as np
import winsound


def captureQR():
    # initiate capture
    capture = cv2.VideoCapture(0)
    # set font for text display
    font = cv2.FONT_HERSHEY_SIMPLEX

    # always loop looking for QR code
    while True:
        _, window = capture.read()
        data = ""
        decodedQR = pyzbar.decode(window)
        for obj in decodedQR:
            # set text at top of window in light blue
            cv2.putText(window, str(obj.data), (40, 40), font, 1,
                        (255, 255, 0), 2)
            data = str(obj.data)
        # show the window scanning
        cv2.imshow("ScannerForCinema", window)

        checkDB(data)

        key = cv2.waitKey(1)
        # esc key breaks
        if key == 27:
            break


def checkDB(data):
    # Create a SQL connection to our SQLite database
    con = sqlite3.connect("../dbApps/Cinema.db")

    cur = con.cursor()

    bookings = [a for a in cur.execute("SELECT * FROM Bookings")]

    email = data.split("ID:", 1)[0]
    email = email[2:]
    details = data.split(" ")

    if len(details) > 1:
        ID = details[1][3:]
        total = details[2][6:-1]

        for b in bookings:
            b = np.asarray(b)
            if (str(b[-1]) == email.strip()) & (str(b[0]) == ID) & (str(b[1]) == total):
                price = b[5]
                price = "${:,.2f}".format(price)
                print("BookingID: " + str(b[0]) + " NumberInBooking: " + str(b[1]) + " Adult: " + str(
                    b[2]) + " Child: " + str(b[3]) +
                      " ShowingID: " + str(b[7]) + " Email: " + str(b[8]) + " Total:" + price)
                frequency = 2500  # Set Frequency To 2500 Hertz
                duration = 1000  # Set Duration To 1000 ms == 1 second
                winsound.Beep(frequency, duration)

    # close the connection
    con.close()
