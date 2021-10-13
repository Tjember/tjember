
 # importing the packages
from tkinter import*
from tkinter import ttk
from tkinter import messagebox
import random
import time
import datetime

root = Tk()
root.geometry("1350x650+0+0")
root.title("TJ HotDog OS")
root.configure(background='black')




# defining the exit button function
def Exit():
    qExit = messagebox.askyesno("TJ HotDog OS ", "Do you want to Exit the system?")
    if qExit > 0:
        root.destroy()
        return

    
# defining the reset function
def Reset():
    CustomerRef.set("")
    Tax.set("")
    SubTotal.set("")
    TotalCost.set("")
    CustomerName.set("")
    CustomerPhone.set("")
    CustomerEmail.set("")
    Discount.set("")

# Defining the order reference function
def OrderRef():
    refPay =random.randint(10000, 7009467)
    Refpaid = ("OS" + str(refPay))
    CustomerRef.set(Refpaid)

# #defining the cost of order function and setting the
#formula to calculate the tax rate, subtotal #and total cost of purchase items
def CostofOrder():
    Qty1=float(QtyHotdog.get())
    Qty2 = float(QtyChilidog.get())
    Qty3 = float(QtyCheesedog.get())
    

    UnitPrice1= float(UnitPriceHotdog.get())
    UnitPrice2 = float(UnitPriceChilidog.get())
    UnitPrice3 = float(UnitPriceCheesedog.get())

    CostofHdog1 = '$', str('%.2f'%(Qty1 * UnitPrice1))
    CostofHdog2 = '$', str('%.2f'%(Qty2 * UnitPrice2))
    CostofHdog3 = '$', str('%.2f'%(Qty3 * UnitPrice3))

    CostofHotdog.set(CostofHdog1 )
    CostofChilidog.set(CostofHdog2)
    CostofCheesedog.set(CostofHdog3)

    AllCost = (Qty1 * UnitPrice1) + (Qty2 * UnitPrice2)+ (Qty3 * UnitPrice3)
    TaxAll= '$', str('%.2f' % ((AllCost) * 0.07))
    Tax.set(TaxAll)
    SubTotalp = '$', str('%.2f' % (AllCost))
    SubTotal.set(SubTotalp)
    TotalCostp= '$', str('%.2f' % (AllCost + ((AllCost) * 0.07)))
    TotalCost.set(TotalCostp)
    return
    


def MakeOrder():
    side_window = Toplevel(root)
    side_window.title("TJ HotDog OS")
    side_window.geometry("1350x650+0+0")
    side_window.configure(background='black')

    close_window=Button(side_window,text="close",command=side_window.destroy)
    close_window.pack()
    main_customerName=str(txtCustomerName.get())
    main_customerName.pack()
    
    
    

   
    
  

# defining variables 
CustomerRef=StringVar()
Tax=StringVar()
SubTotal=StringVar()
TotalCost=StringVar()
CostofHotdog = StringVar()
CostofChilidog = StringVar()
CostofCheesedog = StringVar()
CostofDelivery= StringVar()
CustomerName  = StringVar()
CustomerPhone  = StringVar()
CustomerEmail  = StringVar()
TimeofOrder  = StringVar()
DateofOrder  = StringVar()
Discount  = StringVar()
CostofCheesedog = StringVar()
CostofHotdog = StringVar()
CostofChilidog = StringVar()
UnitPriceCheesedog = StringVar()
UnitPriceHotdog = StringVar()
UnitPriceChilidog= StringVar()
QtyCheesedog = StringVar()
QtyHotdog = StringVar()
QtyChilidog = StringVar()
Discount = StringVar()

# setting initial value for variables
CostofHotdog.set(0)
CostofChilidog.set(0)
CostofCheesedog.set(0)
UnitPriceCheesedog.set(9.5)
UnitPriceChilidog.set(10)
UnitPriceHotdog.set(12)
QtyCheesedog.set(0)
QtyChilidog.set(0)
QtyHotdog .set(0)
Discount.set(0)
TimeofOrder.set(time.strftime("%H:%M:%S"))   # setting the time format value
DateofOrder.set(time.strftime("%m/%d/%y"))   # setting the date format value


# setting the frame
Tops=Frame(root, width=1350, height=50, bd=12, relief="raise")
Tops.pack(side=TOP)
LF = Frame(root, width=700, height=650, bd=46, relief="raise")
LF.pack(side=LEFT)
RF = Frame(root, width=600, height=650, bd=46, relief="raise")
RF.pack(side=RIGHT)

Tops.configure(background='black')
LF.configure(background='black')
RF.configure(background='black')

LeftInsideLF= Frame(LF,width=700, height=100, bd=10, relief="raise")
LeftInsideLF.pack(side = TOP)
LeftInsideLFLF= Frame(LF,width=700, height=400, bd=10, relief="raise")
LeftInsideLFLF.pack(side = LEFT)


RightInsideLF= Frame(RF,width=604, height=200, bd=10, relief="raise")
RightInsideLF.pack(side = TOP)
RightInsideLFLF= Frame(RF,width=306, height=400, bd=10, relief="raise")
RightInsideLFLF.pack(side = LEFT)
RightInsideRFRF= Frame(RF,width=300, height=400, bd=10, relief="raise")
RightInsideRFRF.pack(side = RIGHT)


# putting the label for project title
lblInfo= Label(Tops, font=('arial',50, 'bold'), text = "           TJ HotDog OS               ",
           bd = 10, anchor='w')
lblInfo.grid(row=0,column=0)


# labeling the top left frame
lblCustomerName= Label(LeftInsideLF, font=('arial', 14, 'bold'), text="Customer Name",
                       fg="black",bd=10, anchor='w' )
lblCustomerName.grid(row=0,column=0)
txtCustomerName= Entry(LeftInsideLF, font=('arial', 14, 'bold'), bd=20, width=43,
                       bg="white", justify='left', textvariable=CustomerName)
txtCustomerName.grid(row=0,column=1)

lblCustomerPhone= Label(LeftInsideLF, font=('arial', 14, 'bold'), text="Customer Phone",
                       fg="black",bd=10, anchor='w' )
lblCustomerPhone.grid(row=1,column=0)
txtCustomerPhone= Entry(LeftInsideLF, font=('arial', 14, 'bold'), bd=20, width=43,
                       bg="white", justify='left', textvariable=CustomerPhone)
txtCustomerPhone.grid(row=1,column=1)

lblCustomerEmail= Label(LeftInsideLF, font=('arial', 14, 'bold'), text="Customer Email",
                       fg="black",bd=10, anchor='w' )
lblCustomerEmail.grid(row=2,column=0)
txtCustomerEmail= Entry(LeftInsideLF, font=('arial', 14, 'bold'), bd=20, width=43,
                       bg="white", justify='left', textvariable=CustomerEmail)
txtCustomerEmail.grid(row=2,column=1)


# labeling the Top Right Frame
lblDateofOrder= Label(RightInsideLF, font=('arial', 12, 'bold'), text= "Date of order",
                      fg="black", bd=10,anchor='w')
lblDateofOrder.grid(row=0, column=0)
txtDateofOrder=Entry(RightInsideLF, font=('arial', 12, 'bold'),bd=20,
                     width=42,bg="white", textvariable=DateofOrder)
txtDateofOrder.grid(row=0, column=1)

lblTimeofOrder= Label(RightInsideLF, font=('arial', 12, 'bold'), text= "Time of Order",
                      fg="black", bd=10,anchor='w')
lblTimeofOrder.grid(row=1, column=0)
txtTimeofOrder=Entry(RightInsideLF, font=('arial', 12, 'bold'),bd=20,
                     width=43,bg="white",justify='left', textvariable=TimeofOrder)
txtTimeofOrder.grid(row=1, column=1)

lblCustomerRef= Label(RightInsideLF, font=('arial', 12, 'bold'), text= "Customer Ref",
                      fg="black", bd=10,anchor='w')
lblCustomerRef.grid(row=2, column=0)
txtCustomerRef=Entry(RightInsideLF, font=('arial', 12, 'bold'),bd=20,
                     width=43,bg="white", textvariable=CustomerRef)
txtCustomerRef.grid(row=2, column=1)


# labeling the bottom right frame
lblMethodOfPayment = Label (RightInsideLFLF,font=('arial',12,'bold'),text= "Method Of Payment",
      fg="black", bd= 16, anchor="w")
lblMethodOfPayment.grid(row=0,column=0)
cmdMethodOfPayment = ttk.Combobox(RightInsideLFLF,font=('arial',10,'bold'))
cmdMethodOfPayment['value']= (' ', 'cash','Debit Card ', 'Master Card', 'Discover Card' )
lblMethodOfPayment.grid(row=0,column=1)

lblDiscount =Label( RightInsideLFLF,font=('arial',12,'bold'), text= "Discount",
      fg="black", bd= 16, anchor= 'w')
lblDiscount.grid(row=1,column=0)
txtDiscount = Entry (RightInsideLFLF,font=('arial',12,'bold'),bd=16,width= 18,
      bg="white", justify= 'left', textvariable=Discount)
txtDiscount.grid(row=1,column=1)

lblTax = Label (RightInsideLFLF, font=('arial', 12, 'bold',), text = "Tax",
                fg="black", bd=16, anchor='w')
lblTax.grid(row=2,column=0)
txtTax= Entry (RightInsideLFLF,font=('arial',12,'bold'),bd=16,width= 18,
      bg="white", justify= 'left', textvariable=Tax)
txtTax.grid(row=2,column=1)

lblSubTotal= Label(RightInsideLFLF, font=('arial',12,'bold' ),text="Sub Total ",
                   fg="black", bd=16, anchor='w' )
lblSubTotal.grid(row=3, column=0)
txtSubTotal= Entry (RightInsideLFLF,font=('arial',12,'bold'),bd=16,width= 18,
      bg="white", justify= 'left', textvariable=SubTotal)
txtSubTotal.grid(row=3, column=1)

lblTotalCost= Label(RightInsideLFLF, font=('arial',12,'bold' ),text="Total Cost ",
                   fg="black", bd=16, anchor='w' )
lblTotalCost.grid(row=4, column=0)
txtTotalCost= Entry (RightInsideLFLF,font=('arial',12,'bold'),bd=16,width= 18,
      bg="white", justify= 'left', textvariable=TotalCost)
txtTotalCost.grid(row=4, column=1)


# labeling Left bottom frame
lblItemOrder= Label(LeftInsideLFLF,font=('arial',14,'bold' ),text="Item Order", fg="black", bd=20)
lblItemOrder.grid(row=0, column=0)
lblQty= Label(LeftInsideLFLF,font=('arial',14,'bold' ),text="Qty", fg="black", bd=20)
lblQty.grid(row=0, column=1)
lblUnitPrice= Label(LeftInsideLFLF,font=('arial',14,'bold' ),text="Unit Price", fg="black", bd=20)
lblUnitPrice.grid(row=0, column=2)
lblCostofItem= Label(LeftInsideLFLF,font=('arial',14,'bold' ),text="Cost of Item", fg="black", bd=20)
lblCostofItem.grid(row=0, column=3)

# framing the items list inside left bottom

lblHotdog=Label(LeftInsideLFLF,font=('arial',14,'bold' ),text="Hot Dog ", fg="black", bd=20)
lblHotdog.grid(row=1, column=0)
lblChilidog=Label(LeftInsideLFLF,font=('arial',14,'bold'),text="Chili Dog", fg="black", bd=20)
lblChilidog.grid(row=2, column=0)
lblCheesedog=Label(LeftInsideLFLF,font=('arial',14,'bold'),text="Cheese Dog", fg="black", bd=20)
lblCheesedog.grid(row=3, column=0)

# framing the items quantity inside left bottom

txtQtyHotdog= Entry(LeftInsideLFLF,font=('arial',12,'bold'),bd=20, width=16,
                       bg="white", justify='left',textvariable=QtyHotdog)
txtQtyHotdog.grid(row=1, column=1)
txtQtyChilidog= Entry(LeftInsideLFLF,font=('arial',12,'bold'),bd=20, width=16,
                       bg="white", justify='left',textvariable=QtyChilidog)
txtQtyChilidog.grid(row=2, column=1)
txtQtyCheesedog= Entry(LeftInsideLFLF,font=('arial',12,'bold'),bd=20, width=16,
                       bg="white", justify='left',textvariable=QtyCheesedog)
txtQtyCheesedog.grid(row=3, column=1)


# framing the unit price inside left bottom
txtUnitPriceHotdog= Entry(LeftInsideLFLF,font=('arial',12,'bold'),bd=20, width=16,
                       bg="white", justify='left',textvariable=UnitPriceHotdog)
txtUnitPriceHotdog.grid(row=1, column=2)
txtUnitPriceChilidog= Entry(LeftInsideLFLF,font=('arial',12,'bold'),bd=20, width=16,
                       bg="white", justify='left',textvariable=UnitPriceChilidog)
txtUnitPriceChilidog.grid(row=2, column=2)
txtUnitPriceCheesedog= Entry(LeftInsideLFLF,font=('arial',12,'bold'),bd=20, width=16,
                       bg="white", justify='left',textvariable=UnitPriceCheesedog)
txtUnitPriceCheesedog.grid(row=3, column=2)



# framing the total cost of each hot dog  inside left bottom

txtCostofHotdog=Entry(LeftInsideLFLF,font=('arial',12,'bold'),bd=20, width=16,
                       bg="white", justify='left',textvariable=CostofHotdog)
txtCostofHotdog.grid(row=1, column=3)
txtCostofChilidog=Entry(LeftInsideLFLF,font=('arial',12,'bold'),bd=20, width=16,
                       bg="white", justify='left',textvariable=CostofChilidog)
txtCostofChilidog.grid(row=2, column=3)
txtCostofCheesedog=Entry(LeftInsideLFLF,font=('arial',12,'bold'),bd=20, width=16,
                       bg="white", justify='left',textvariable=CostofCheesedog)
txtCostofCheesedog.grid(row=3, column=3)



# buttons frame
btnTotalCost = Button(RightInsideRFRF,pady=8,bd=8,fg="black",font=('arial',16,'bold'), width=11,
          text= "Total Cost",bg="white", command=CostofOrder).grid(row=0,column=0)
btnReset = Button(RightInsideRFRF,pady=8,bd=8,fg="black", font=('arial',16,'bold'), width=11,
          text="Reset",bg="white", command=Reset).grid(row=1,column=0)
btnOrderRef = Button(RightInsideRFRF,pady=8,bd=8,fg="black", font=('arial',16,'bold'), width=11,
          text="Order Ref",bg="white", command=OrderRef).grid(row=2,column=0)

btnExit = Button(RightInsideRFRF,pady=8,bd=8,fg="black", font=('arial',16,'bold'), width=11,
          text="Exit",bg="white", command=Exit).grid(row=3,column=0)
btnMakeOrder=Button(RightInsideRFRF,pady=8,bd=8,fg="black", font=('arial',16,'bold'), width=11,
          text="Submit Order",bg="white", command=MakeOrder).grid(row=4,column=0)

root.mainloop()
