enum Menu {
    AMERICAN = 1,
    JAPANESE,
    INDIAN,
    ITALIAN
}

const customerChoice:Menu = Menu.ITALIAN;

switch (+customerChoice) {
    case 1:
        console.log(`Customer Made American Food Choice`);
        break;
    case 2:
        console.log(`Customer Made Japanese Food Choice`);
        break;
    case 3:
        console.log(`Customer Made Indian Food Choice`);
        break;
    case 4:
        console.log(`Customer Made Italian Food Choice`);
        break;
    default:
        console.log(`We don't serve this food!`);
}