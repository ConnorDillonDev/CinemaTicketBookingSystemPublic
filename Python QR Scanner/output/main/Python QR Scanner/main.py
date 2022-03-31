import scan_webcam


def start(name):
    print(f'CinemaTicketScanner, {name}')
    scan_webcam.captureQR()

# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    start('STAFF')


