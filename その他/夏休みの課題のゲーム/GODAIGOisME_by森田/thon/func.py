def create_mail(recv,bill):
    tmp = '''
{}様
新座太郎です。
連絡ください。
{}円返してください。
'''
    msg = tmp.format(recv,bill)
    print(msg)

def add_charge(bill):
    return int(bill * 1.07)
