#LineRead2.py
def Main():
  infile = open('disks.txt','r')
  line1 = infile.readline()
  line1=line1.rstrip('\n')
  #input('press ENTER to continue...')
  print(line1)
  infile.close()

  input('Press ENTER to close...')

Main()
