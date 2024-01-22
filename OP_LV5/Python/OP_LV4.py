from tkinter import Canvas, filedialog, Frame, Menu, Tk
import pandas as pd
import socket
import threading as thrd


class GrafLik:
    """Klasa GrafLik"""

    def __init__(self, boja, tocka):
        self.boja = boja
        self.tocka = tocka

    def SetColor(self, boja):
        """Metoda postavi boju"""
        self.boja = boja

    def GetColor(self):
        """Metoda dohvati boju"""
        return self.boja

    def Draw(self):
        """Nacrtaj oblik - osnovna metoda"""
        return


class Linija(GrafLik):
    """Klasa Linija"""

    def __init__(self, boja, tocka, tocka2):
        GrafLik.__init__(self, boja, tocka)
        self.tocka2 = tocka2

    def Draw(self, canvas):
        """Nacrtaj oblik - izvedena metoda"""
        canvas.create_line(self.tocka + self.tocka2, fill=self.GetColor())


class Pravokutnik(GrafLik):
    """Klasa Pravokutnik"""

    def __init__(self, boja, tocka, tocka2, tocka3):
        GrafLik.__init__(self, boja, tocka)
        self.tocka2 = tocka2
        self.tocka3 = tocka3

    def Draw(self, canvas):
        """Nacrtaj oblik - izvedena metoda"""
        canvas.create_rectangle(
            self.tocka
            + [
                float(self.tocka[0]) + float(self.tocka2),
                float(self.tocka[1]) + float(self.tocka3),
            ],
            outline=self.GetColor(),
            fill="",
        )


class Poligon(GrafLik):
    """Klasa Poligon"""

    def __init__(self, boja, tocka, tocke):
        GrafLik.__init__(self, boja, tocka)
        self.tocke = tocke

    def Draw(self, canvas):
        """Nacrtaj oblik - izvedena metoda"""
        canvas.create_polygon(self.tocka + self.tocke, outline=self.GetColor(), fill="")


class Kruznica(GrafLik):
    """Klasa Kruznica"""

    def __init__(self, boja, tocka, tocka2):
        GrafLik.__init__(self, boja, tocka)
        self.tocka2 = tocka2

    def Draw(self, canvas):
        """Nacrtaj oblik - izvedena metoda"""
        canvas.create_oval(
            self.tocka
            + [
                float(self.tocka[0]) + float(self.tocka2),
                float(self.tocka[1]) + float(self.tocka2),
            ],
            outline=self.GetColor(),
            fill="",
        )


class Trokut(Linija):
    """Klasa Trokut"""

    def __init__(self, boja, tocka, tocka2, tocka3):
        Linija.__init__(self, boja, tocka, tocka2)
        self.tocka3 = tocka3

    def Draw(self, canvas):
        """Nacrtaj oblik - izvedena metoda"""
        canvas.create_polygon(
            self.tocka + self.tocka2 + self.tocka3, outline=self.GetColor(), fill=""
        )


class Elipsa(Kruznica):
    """Klasa Elipsa"""

    def __init__(self, boja, tocka, tocka2, tocka3):
        Kruznica.__init__(self, boja, tocka, tocka2)
        self.tocka3 = tocka3

    def Draw(self, canvas):
        """Nacrtaj oblik - izvedena metoda"""
        canvas.create_oval(
            self.tocka
            + [
                float(self.tocka[0]) + float(self.tocka2),
                float(self.tocka[1]) + float(self.tocka3),
            ],
            outline=self.GetColor(),
            fill="",
        )


class Application(Frame):
    def initializeCanvas(self):
        self.canvas = Canvas(self, bg="#999999", width=800, height=600)
        self.canvas.pack()

    def __init__(self, master=None):
        Frame.__init__(self, master)
        self.master = master
        menu = Menu(self.master)
        self.master.config(menu=menu)
        file_menu = Menu(menu)
        server_menu = Menu(menu)
        file_menu.add_command(label="Open", command=self.openThread)
        server_menu.add_command(label="Start Server", command=self.threading)
        file_menu.add_command(label="Exit", command=self.quit)
        menu.add_cascade(label="File", menu=file_menu)
        menu.add_cascade(label="Server", menu=server_menu)
        self.pack()
        self.initializeCanvas()

    def threading(self):
        listensocket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        port = 8000
        maxConnections = 10
        name = socket.gethostname()
        listensocket.bind(("localhost", port))
        listensocket.listen(maxConnections)
        self.listensocket = listensocket
        serverString = "Started server at " + str(name) + " on port " + str(port)
        self.canvas.create_text(580, 580, text=serverString, fill="white", font=("Helvetica 12 bold"))
        self.logString(serverString, "title")
        thrd1 = thrd.Thread(target=self.clientHandler)
        thrd1.start()

    def clientHandler(self):
        while True:
            (clientsocket, address) = self.listensocket.accept()
            connectionString = "New connection made from addres: " + str(address)
            print("New connection made from address: ", address)
            self.logString(connectionString, "title")
            thrd2 = thrd.Thread(target=self.Srv_func, args=(clientsocket,))
            thrd2.daemon = True
            thrd2.start()

    def openThread(self):
        thrd1 = thrd.Thread(target=self.readFile())
        thrd1.daemon = True
        thrd1.start()

    def readFile(self):
        path = filedialog.askopenfilename()
        text = pd.read_csv(path, header=None)
        self.path = path
        self.logString(self.getFileName(), "title")

        retci = []
        for redak in text[0]:
            retci.append(redak)

        oblici = []
        for oblik in retci:
            oblici.append(oblik.split())

        for oblik in oblici:
            self.drawShape(oblik)

    def drawShape(self, oblik):
        if oblik[0] == "Line":
            linija = Linija(oblik[1], oblik[2:4], oblik[4:6])
            linija.Draw(self.canvas)

        elif oblik[0] == "Rectangle":
            pravokutnik = Pravokutnik(oblik[1], oblik[2:4], oblik[4], oblik[5])
            pravokutnik.Draw(self.canvas)

        elif oblik[0] == "Polygon":
            poligon = Poligon(oblik[1], oblik[2:4], oblik[4:])
            poligon.Draw(self.canvas)

        elif oblik[0] == "Circle":
            kruznica = Kruznica(oblik[1], oblik[2:4], oblik[4])
            kruznica.Draw(self.canvas)

        elif oblik[0] == "Triangle":
            trokut = Trokut(oblik[1], oblik[2:4], oblik[4:6], oblik[6:8])
            trokut.Draw(self.canvas)

        elif oblik[0] == "Ellipse":
            elipsa = Elipsa(oblik[1], oblik[2:4], oblik[4], oblik[5])
            elipsa.Draw(self.canvas)

    def logString(self, log, type):
        if type == "title":
            self.canvas.create_rectangle(
                155, 622, 645, 645, outline="gray", fill="gray"
            )
            self.canvas.create_text(
                400, 630, text=log, fill="white", font=("Helvectica 12 bold")
            )
        else:
            self.canvas.create_rectangle(
                155, 645, 645, 678, outline="gray", fill="gray"
            )
            self.canvas.create_text(
                400, 650, text=log, fill="white", font=("Helvecita 12 bold")
            )

    def getFileName(self):
        print("File name: ", self.path.split("/")[-1])
        return self.path.split("/")[-1]

    def Srv_func(self, cs):
        while True:
            message = cs.recv(1024).decode()
            oblik = message.replace(",", ".")
            print(oblik.split())
            self.logString(str(oblik.split()[0:2]), "object")
            self.drawShape(oblik.split())


def main():
    root = Tk()
    app = Application(root)
    root.wm_title("Objektno programiranje - LV5")
    app.mainloop()


if __name__ == "__main__":
    main()
