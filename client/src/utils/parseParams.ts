export const parseParamToInt = (value: string | undefined | null): number => {
  let convertedValue: number = 0;
  if (value !== undefined && value !== null) {
    convertedValue = parseInt(value);
  }
  return convertedValue;
};
