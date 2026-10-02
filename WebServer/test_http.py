import requests

# update the DEFAULT_PORT below to the port you are using
# then in the directory with this script run tests using:
# python3 -m pytest -v

DEFAULT_HOST='127.0.0.1'
DEFAULT_PORT=11111

headers = { 'Accept-Encoding': '*' }
base_url = f"http://{DEFAULT_HOST}:{DEFAULT_PORT}"

def test_root():
    url = f"{base_url}/"
    resp = requests.get(url, headers=headers)

    assert resp.status_code == 200
    assert resp.headers['Content-Length'] == '359'
    assert resp.headers['Content-Type'] == 'text/html'


def test_html():
    url = f"{base_url}/index.html"
    resp = requests.get(url, headers=headers)

    assert resp.status_code == 200
    assert resp.headers['Content-Length'] == '359'
    assert resp.headers['Content-type'] == 'text/html'


def test_jpg():
    url = f"{base_url}/blue.jpg"
    resp = requests.get(url, headers=headers)

    assert resp.status_code == 200
    assert resp.headers['Content-Length'] == '130786'
    assert resp.headers['Content-type'] == 'image/jpeg'


def test_png():
    url = f"{base_url}/logo.png"
    resp = requests.get(url, headers=headers)

    assert resp.status_code == 200
    assert resp.headers['Content-Length'] == '54205'
    assert resp.headers['Content-type'] == 'image/png'


def test_css():
    url = f"{base_url}/style.css"
    resp = requests.get(url, headers=headers)

    assert resp.status_code == 200
    assert resp.headers['Content-Length'] == '150'
    assert resp.headers['Content-type'] == 'text/css'


def test_304():
    url = f"{base_url}/index.html"
    resp = requests.get(url, headers=headers)

    local_headers = headers.copy()
    local_headers['If-Modified-Since'] = resp.headers['Last-Modified']
    resp = requests.get(url, headers=local_headers)
    assert resp.status_code == 304


def test_404():
    url = f"{base_url}/nonexistent.file"
    resp = requests.get(url, headers=headers)

    assert resp.status_code == 404