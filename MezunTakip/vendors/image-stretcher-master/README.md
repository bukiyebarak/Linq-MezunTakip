# ImageStretcher.js

Reference [ashhitch/ImageStretcher.js](https://gist.github.com/ashhitch/8dc9a4264a47f2b8e4d5)

## Installation

```sh
bower install image-stretcher
```
or
```sh
npm install image-stretcher
```

## Usage

```js
function initBackgroundResize() {
	jQuery('.visual-area').each(function() {
		ImageStretcher.add({
			container: this,
			image: 'img.bg-stretch'
		});
	});
}
```