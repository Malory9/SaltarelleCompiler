///////////////////////////////////////////////////////////////////////////////
// IEnumerable

var ss_IEnumerable = function#? DEBUG IEnumerable$##() { };
ss_IEnumerable.prototype = {
	getEnumerator: null
};

ss.registerInterface(global, 'ss.IEnumerable', ss_IEnumerable);

ss.getEnumerator = function#? DEBUG ss$getEnumerator##(obj) {
	return obj.getEnumerator ? obj.getEnumerator() : new ss_ArrayEnumerator(obj);
};
